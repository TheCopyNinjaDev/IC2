using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;


public class Socket : MonoBehaviour, IDropHandler
{
    private Vector2 _position;

    public void SetPosition(Vector2 position)
    {
        _position = position;
    }
    
    public void OnDrop(PointerEventData eventData)
    {
        var draggable = eventData.pointerDrag.GetComponent<Draggable>();
        if (draggable != null)
        {
            GetComponent<Image>().sprite = draggable.GetComponent<Image>().sprite;
        }
    }
}
