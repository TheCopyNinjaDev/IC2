using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

// Класс ItemGenerator отвечает за создание сетки предметов.
public class ItemGenerator : GridMaker
{
    // Список предметов, которые будут размещены в сетке.
    public List<Item> items;

    // Start вызывается перед первым обновлением кадра.
    private void Start()
    {
        // Расчет количества строк на основе количества предметов и количества строк.
        numberOfRows = items.Count / numberOfRows;
        // Расчет количества столбцов на основе количества предметов и количества столбцов.
        numberOfColumns = items.Count % numberOfColumns + numberOfColumns;
      
        // Вызов метода для генерации сетки с заданными параметрами.
        GenerateGrid(numberOfRows, numberOfColumns, gridOffset);
    }

    // Переопределенный метод GenerateGrid для создания сетки.
    protected override void GenerateGrid(int rows, int columns, float offset)
    {
        // Вызов базового метода GenerateGrid.
        base.GenerateGrid(rows, columns, offset);

        // Индекс для перебора списка предметов.
        var i = 0;
        // Перебор всех сокетов (ячеек сетки).
        foreach (var socket in Sockets)
        {
            // Установка спрайта для каждого сокета из списка предметов.
            socket.GetComponent<Image>().sprite = items[i].ItemSprite;
            // Увеличение индекса для следующего предмета.
            i++;
        }
    }
}