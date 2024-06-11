using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Класс Item представляет предмет в реакторе.
public class Item : MonoBehaviour
{
    // Спрайт, который будет использоваться для отображения предмета.
    public Sprite ItemSprite;
    // Приватная переменная для хранения позиции предмета.
    private Vector2 _position;

    // Конструктор класса, который устанавливает позицию предмета.
    public Item(Vector2 position)
    {
        // Установка позиции предмета.
        _position = position;
    }
}