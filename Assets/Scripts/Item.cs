using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Sprite ItemSprite;
    private Vector2 _position;

    public Item(Vector2 position)
    {
        _position = position;
    }
}
