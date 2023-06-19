using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Slots : MonoBehaviour
{
    public Receitas receita;
    public Image[] slotArray;
    public float distance = 145f;
    public Sprite slotImageFundo;
    public Pontuacao ponts;

    public void SpawnSlots()
    {
        slotArray = new Image[3];
        for (int i = 0; i < slotArray.Length; i++)
        {
            GameObject slots = new GameObject("Slot" + i.ToString());
            Image slotFundo = slots.AddComponent<Image>();
            slotFundo.sprite = slotImageFundo;

            RectTransform rectTransform = slots.GetComponent<RectTransform>();
            rectTransform.SetParent(transform);
            rectTransform.tag = "Slot" + i.ToString();
            rectTransform.localScale = Vector3.one;
            rectTransform.anchoredPosition = new Vector2(i * distance, 0f);
            GridLayoutGroup gridLayout = rectTransform.AddComponent<GridLayoutGroup>();
            gridLayout.childAlignment = TextAnchor.MiddleCenter;
            gridLayout.cellSize = new Vector2(80, 80);

            Droppable droppableRef = rectTransform.AddComponent<Droppable>();
            droppableRef.receitaRef = receita;
            droppableRef.ponts = ponts;
        }
    }
}
