using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "novaReceita", menuName = "Receita")]
public class Receita_SO : ScriptableObject
{
    public Sprite lancheImg;
    public string lancheName;

    public string[] listaIngredientes = new string[3];

    public int pontos;
}
