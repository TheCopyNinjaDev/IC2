using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoHandler : MonoBehaviour
{
    void Start()
    {
        UpdateInfo(0, 0, 0, 0);
    }
    
    public void UpdateInfo(float heat, float energy, float effectivity, float fuel)
    {
        TextMeshProUGUI textMeshPro = GetComponent<TextMeshProUGUI>();
        
        if(textMeshPro != null)
            textMeshPro.text = GetCycleStats(heat, energy, effectivity, fuel); 
    }

    private string GetCycleStats(float heat, float energy, float effectivity, float fuel)
    {
        return "Info:\n" +
               $"Heat per cycle: {heat}\n" +
               $"Energy per cycle: {energy}\n" +
               $"Effectivity: {effectivity}\n" +
               $"Amount of fuel: {fuel}";
    }
}
