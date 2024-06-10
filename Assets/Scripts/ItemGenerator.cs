using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class ItemGenerator : GridMaker
{
    public List<Item> items;

    private void Start()
    {
        numberOfRows = items.Count / numberOfRows;
        numberOfColumns = items.Count % numberOfColumns + numberOfColumns;
        
        GenerateGrid(numberOfRows, numberOfColumns, gridOffset);
    }

    protected override void GenerateGrid(int rows, int columns, float offset)
    {
        base.GenerateGrid(rows, columns, offset);

        var i = 0;
        foreach (var socket in Sockets)
        {
            socket.GetComponent<Image>().sprite = items[i].ItemSprite;
            i++;
        }
    }
}
