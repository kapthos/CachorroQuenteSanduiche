using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IngredientsProp : MonoBehaviour
{
    public Ingredientes_SO ingrediente;

    public Sprite ingredientImg;
    public string ingredientName;
    public int ingredientID;

    private void Start()
    {
        ingredientImg = ingrediente.ingredientImg;
        ingredientName = ingrediente.ingredientName;
        ingredientID = ingrediente.id;
    }
}
