using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "novoIngrediente", menuName = "Ingredientes")]
public class Ingredientes_SO : ScriptableObject
{
    public Sprite ingredientImg;
    public string ingredientName;
    public int id;
}
