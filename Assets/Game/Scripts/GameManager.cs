using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class GameManager : MonoBehaviour
{
    public Slots slotsGMRef;
    public GameObject slotManager;
    public Droppable slotCriadoGMRef;

    public Receitas receitasRef;

    public Image button;
    public TMP_Text dinheiro;

    public static int pontuacaoAtual = 0;

    private void Awake()
    {
        GameControl();
    }
    void Start()
    {
        slotCriadoGMRef = FindObjectOfType<Droppable>();
        receitasRef = FindObjectOfType<Receitas>();
    }

    void Update()
    {

    }

    public void GameControl()
    {
        slotsGMRef.SpawnSlots();
    }

    public void Controle()
    {
        bool sequenciaCorreta = slotCriadoGMRef.correctSequenceCheck;

        if (sequenciaCorreta)
        {
            pontuacaoAtual += receitasRef.receitaAtual.pontos;
            dinheiro.text = pontuacaoAtual.ToString();
            foreach (RectTransform child in slotManager.transform)
            {
                Destroy(child.gameObject);
            }
            receitasRef.ReceitaAtual();
            slotsGMRef.SpawnSlots();
        }
    }
}
