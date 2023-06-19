using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TelaFinal : MonoBehaviour
{
    public TMP_Text pontuacaoFinal;
    public string LevelName;
    public string MenuName;

    public void Start()
    {
        pontuacaoFinal.text = GameManager.pontuacaoAtual.ToString();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(LevelName);
    }

    public void BackMenu()
    {
        SceneManager.LoadScene(MenuName);
    }
}
