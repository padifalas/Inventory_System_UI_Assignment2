using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;
    private Vector2 initialPosition;

    // Change these variables according to your inventory slot size
    private float slotSize = 1.0f;
    private Vector2 inventoryOffset = new Vector2(0.0f, 0.0f); // Offset of the inventory grid

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                // Calculate the offset between the object's position and the mouse position
                offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
                isDragging = true;
                initialPosition = transform.position;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (isDragging)
            {
                SnapToInventorySlot();
            }
            isDragging = false;
        }

        if (isDragging)
        {
            // Convert the mouse position to world position and add the offset
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;

            // Update the object's position
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
        }
    }

    private void SnapToInventorySlot()
    {
        float snapX = Mathf.Round((transform.position.x - inventoryOffset.x) / slotSize) * slotSize + inventoryOffset.x;

        float snapY = Mathf.Round((transform.position.y - inventoryOffset.y) / slotSize) * slotSize + inventoryOffset.y;

        transform.position = new Vector2(snapX, snapY);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
}