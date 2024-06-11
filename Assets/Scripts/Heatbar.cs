using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Класс Heatbar управляет индикатором тепла.
public class Heatbar : MonoBehaviour
{
    // Максимальное значение тепла.
    public float maxHeat = 100;
    // Градиент для изменения цвета индикатора.
    public Gradient Gradient;
  
    // Ссылка на компонент Slider.
    private Slider _slider;
  
    // Awake вызывается при инициализации скрипта.
    void Awake()
    {
        // Получаем компонент Slider.
        _slider = GetComponent<Slider>();
    }

    // Устанавливает текущее значение тепла.
    public void SetHeat(float heat)
    {
        // Устанавливаем значение слайдера, преобразованное в диапазон от 0 до 1.
        _slider.value = heat / maxHeat;

        // Обновляем цвет индикатора.
        UpdateColor();
        // Обновляем информацию о тепле.
        UpdateHeatInfo(heat);
    }

    // Обновляет цвет индикатора в соответствии с текущим значением.
    public void UpdateColor()
    {
        // Изменяем цвет изображения и текста в соответствии с текущим значением слайдера.
        GetComponentInChildren<Image>().color = Gradient.Evaluate(_slider.normalizedValue);
        GetComponentInChildren<TextMeshProUGUI>().color = Gradient.Evaluate(_slider.normalizedValue);
    }

    // Обновляет текстовую информацию о текущем значении тепла.
    private void UpdateHeatInfo(float heat)
    {
        // Устанавливаем текстовое представление текущего значения тепла.
        GetComponentInChildren<TextMeshProUGUI>().text = $"{heat} degrees";
    }
}