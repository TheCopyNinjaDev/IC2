using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Класс InfoHandler управляет отображением информации о цикле.
public class InfoHandler : MonoBehaviour
{
    // Start вызывается перед первым обновлением кадра.
    void Start()
    {
        // Инициализируем информацию с нулевыми значениями.
        UpdateInfo(0, 0, 0, 0);
    }
  
    // Обновляет информацию на экране.
    public void UpdateInfo(float heat, float energy, float effectivity, float fuel)
    {
        // Получаем компонент TextMeshProUGUI, который отображает текст.
        TextMeshProUGUI textMeshPro = GetComponent<TextMeshProUGUI>();
      
        // Если компонент найден, обновляем текст.
        if(textMeshPro != null)
            textMeshPro.text = GetCycleStats(heat, energy, effectivity, fuel);
    }

    // Возвращает строку с информацией о цикле.
    private string GetCycleStats(float heat, float energy, float effectivity, float fuel)
    {
        // Формируем строку с данными о цикле.
        return "Info:\n" +
               $"Heat per cycle: {heat}\n" + // Тепло за цикл.
               $"Energy per cycle: {energy}\n" + // Энергия за цикл.
               $"Effectivity: {effectivity}\n" + // Эффективность.
               $"Amount of fuel: {fuel}"; // Количество топлива.
    }
}