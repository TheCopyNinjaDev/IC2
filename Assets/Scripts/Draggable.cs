using UnityEngine;
using UnityEngine.EventSystems;

// Класс Draggable позволяет объекту быть перетаскиваемым в пользовательском интерфейсе.
public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    // RectTransform используется для управления позицией и размером объекта UI.
    private RectTransform rectTransform;
    // CanvasGroup позволяет изменять прозрачность объекта UI и его взаимодействие.
    private CanvasGroup canvasGroup;
    // Canvas, к которому принадлежит объект UI.
    private Canvas canvas;
    // Исходная позиция объекта UI перед началом перетаскивания.
    private Vector2 originalPosition;

    // Awake вызывается при инициализации скрипта.
    void Awake()
    {
        // Получаем компоненты, необходимые для работы перетаскивания.
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = GetComponentInParent<Canvas>();
    }

    // OnBeginDrag вызывается в момент начала перетаскивания объекта.
    public void OnBeginDrag(PointerEventData eventData)
    {
        // Запоминаем исходную позицию объекта.
        originalPosition = rectTransform.anchoredPosition;
        // Уменьшаем прозрачность объекта, чтобы показать, что он перетаскивается.
        canvasGroup.alpha = 0.6f;
        // Блокируем возможность взаимодействия с объектом во время перетаскивания.
        canvasGroup.blocksRaycasts = false;
    }

    // OnDrag вызывается при перетаскивании объекта.
    public void OnDrag(PointerEventData eventData)
    {
        // Изменяем позицию объекта в соответствии с перемещением курсора/пальца.
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    // OnEndDrag вызывается, когда перетаскивание объекта заканчивается.
    public void OnEndDrag(PointerEventData eventData)
    {
        // Возвращаем объект на исходную позицию.
        rectTransform.anchoredPosition = originalPosition;
        // Восстанавливаем прозрачность объекта.
        canvasGroup.alpha = 1f;
        // Возобновляем возможность взаимодействия с объектом.
        canvasGroup.blocksRaycasts = true;
    }
}
