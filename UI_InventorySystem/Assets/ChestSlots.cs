using UnityEngine;
using UnityEngine.EventSystems;

public class ChestSlot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        // Check if an item is being dragged
        if (eventData.pointerDrag != null)
        {
            // Move the dragged item into this slot
            eventData.pointerDrag.transform.SetParent(transform);
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
        }
    }
}