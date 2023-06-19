using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image img;
    [HideInInspector] public Transform parentAfterDrag;
    

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentAfterDrag = transform.parent;
        Image testee = GetComponent<Image>();
        Instantiate(testee, parentAfterDrag);
        transform.SetParent(transform.parent);
        transform.SetAsLastSibling();
        img.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentAfterDrag);
        img.raycastTarget = true;
    }
}
