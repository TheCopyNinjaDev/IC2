using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Socket : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        var draggable = eventData.pointerDrag.GetComponent<Draggable>();
        if (draggable != null)
        {
            GetComponent<Image>().color = Color.green;
        }
    }
}
