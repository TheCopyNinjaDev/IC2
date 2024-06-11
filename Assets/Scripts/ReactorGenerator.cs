using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

// Класс ReactorGenerator отвечает за создание и управление сеткой реактора.
public class ReactorGenerator : GridMaker
{
    // Спрайт, используемый по умолчанию для сокетов.
    [FormerlySerializedAs("Original Sprite")] public Sprite originalSprite;
  
    // Метод для очистки реактора, устанавливает спрайт по умолчанию для всех сокетов.
    public void ClearReactor()
    {
        // Проходим по всем сокетам и устанавливаем оригинальный спрайт.
        foreach (var socket in Sockets)
        {
            socket.GetComponent<Image>().sprite = originalSprite;
        }
    }
  
    // Переопределенный метод для генерации сетки.
    protected override void GenerateGrid(int rows, int columns, float offset)
    {
        // Вызов базового метода для создания сетки.
        base.GenerateGrid(rows, columns, offset);

        // Установка позиции для каждого сокета в сетке.
        for (var i = 0; i < Sockets.Count; i++)
        {
            // Расчет позиции сокета и установка ее.
            Sockets[i].GetComponent<Socket>().SetPosition(new Vector2(i / numberOfRows, i % numberOfColumns));
        }
    }
}