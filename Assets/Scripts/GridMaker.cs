using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

public class GridMaker : MonoBehaviour
{
    public GameObject socketPrefab;
    [FormerlySerializedAs("NumberOfRows")] public int numberOfRows = 3;
    [FormerlySerializedAs("NumberOfColumns")] public int numberOfColumns = 3;
    [FormerlySerializedAs("GridOffset")] public float gridOffset = 100;
    protected List<GameObject> Sockets = new List<GameObject>();


    private void Start()
    {
        GenerateGrid(numberOfRows, numberOfColumns, gridOffset);
    }
    
    protected virtual void GenerateGrid(int rows, int columns, float offset)
    {
        var parentRect = GetComponent<RectTransform>().rect;
        var parentWidth = parentRect.width;
        var parentHeight = parentRect.height;

        var potentialSocketWidth = (parentWidth - (numberOfColumns - 1) * offset) / numberOfColumns;
        var potentialSocketHeight = (parentHeight - (numberOfRows - 1) * offset) / numberOfRows;

        var squareSize = Mathf.Min(potentialSocketWidth, potentialSocketHeight);

        var startX = -parentWidth / 2 + squareSize / 2;
        var startY = parentHeight / 2 - squareSize / 2;
        
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < columns; j++)
            {
                var newSocket = Instantiate(socketPrefab, transform);
                Sockets.Add(newSocket);

                var posX = startX + j * (squareSize + offset);
                var posY = startY - i * (squareSize + offset);

                var socketRect = newSocket.GetComponent<RectTransform>();
                socketRect.anchoredPosition = new Vector2(posX, posY);
                socketRect.sizeDelta = new Vector2(squareSize, squareSize);
            }
        }
    }
}
