using UnityEngine;
using UnityEngine.EventSystems;

public class Droppable : MonoBehaviour, IDropHandler
{
    public Receitas receitaRef;
    public static int contador = 0;
    public Pontuacao ponts;

    private int totalSlots;

    public bool correctSequenceCheck = false;

    private void Start()
    {
        UpdateTotalSlots();
    }

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        if (transform.childCount == 0)
        {
            string draggedObjectID = dropped.GetComponent<IngredientsProp>().ingredientName;

            switch (transform.tag)
            {
                case "Slot0":
                    if (draggedObjectID == receitaRef.ingr1)
                    {
                        DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
                        draggableItem.parentAfterDrag = transform;
                        if (contador >= 3)
                        {
                            contador = 0;
                        }
                        contador++;
                    }
                    else
                    {
                        Destroy(dropped);
                    }
                    break;
                case "Slot1":
                    if (draggedObjectID == receitaRef.ingr2)
                    {
                        DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
                        draggableItem.parentAfterDrag = transform;
                        if (contador >= 3)
                        {
                            contador = 0;
                        }
                        contador++;
                    }
                    else
                    {
                        Destroy(dropped);
                    }
                    break;
                case "Slot2":
                    if (draggedObjectID == receitaRef.ingr3)
                    {
                        DraggableItem draggableItem = dropped.GetComponent<DraggableItem>();
                        draggableItem.parentAfterDrag = transform;
                        if (contador >= 3)
                        {
                            contador = 0;
                        }
                        contador++;
                    }
                    else
                    {
                        Destroy(dropped);
                    }
                    break;
            }
            UpdateTotalSlots();
            if (contador == totalSlots)
            {
                correctSequenceCheck = true;
            }
            else
            {
                correctSequenceCheck = false;
            }
            Debug.Log(contador);
            Debug.Log(totalSlots);
            Debug.Log(correctSequenceCheck);
        }
    }

    private void UpdateTotalSlots()
    {
        totalSlots = transform.parent.childCount;
        if (totalSlots > 3)
        {
            totalSlots = 3;
        }
    }
}