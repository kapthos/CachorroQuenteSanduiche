using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Receitas : MonoBehaviour
{
    public Receita_SO receitaAtual;
    public Receita_SO[] receitas = new Receita_SO[5];

    [SerializeField] private Image lanche_Image;
    [SerializeField] private TMP_Text lancheName_Text;

    [SerializeField] private TMP_Text lancheIngrediente01_Text;
    [SerializeField] private TMP_Text lancheIngrediente02_Text;
    [SerializeField] private TMP_Text lancheIngrediente03_Text;

    public string ingr1;
    public string ingr2;
    public string ingr3;

    [SerializeField] private int lanchePontos;

    private void Awake()
    {
        ingr1 = receitaAtual.listaIngredientes[0];
        ingr2 = receitaAtual.listaIngredientes[1];
        ingr3 = receitaAtual.listaIngredientes[2];
    }
    void Start()
    {
        ReceitaAtual();
    }

    private void Update()
    {
    }

    public void ReceitaAtual()
    {
        lanche_Image.sprite = receitaAtual.lancheImg;
        lancheName_Text.text = receitaAtual.lancheName;
        lancheIngrediente01_Text.text = receitaAtual.listaIngredientes[0];
        lancheIngrediente02_Text.text = receitaAtual.listaIngredientes[1];
        lancheIngrediente03_Text.text = receitaAtual.listaIngredientes[2];
        lanchePontos = receitaAtual.pontos;

        ingr1 = receitaAtual.listaIngredientes[0];
        ingr2 = receitaAtual.listaIngredientes[1];
        ingr3 = receitaAtual.listaIngredientes[2];

        for (int i = 0; i < receitas.Length; i++)
        {
            int randomIndex = Random.Range(0, receitas.Length);
            receitaAtual = receitas[randomIndex];

            if (receitas[i] == receitaAtual)
            {
                int nextIndex = (i + 1) % receitas.Length;
                receitaAtual = receitas[nextIndex];
                break;
            }
        }
    }
}
