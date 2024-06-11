using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

// Класс Socket представляет собой сокет, который может принимать перетаскиваемые объекты.
public class Socket : MonoBehaviour, IDropHandler
{
    // Приватная переменная для хранения позиции сокета.
    private Vector2 _position;

    // Метод для установки позиции сокета.
    public void SetPosition(Vector2 position)
    {
        _position = position;
    }
  
    // Метод, вызываемый когда объект перетаскивается и отпускается над сокетом.
    public void OnDrop(PointerEventData eventData)
    {
        // Получаем компонент Draggable из объекта, который был перетащен.
        var draggable = eventData.pointerDrag.GetComponent<Draggable>();
        // Если объект действительно можно перетаскивать,
        if (draggable != null)
        {
            // То устанавливаем спрайт перетаскиваемого объекта в текущий сокет.
            GetComponent<Image>().sprite = draggable.GetComponent<Image>().sprite;
        }
    }
}