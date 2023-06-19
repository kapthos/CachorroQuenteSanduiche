using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private float timeLeft;
    [SerializeField] private bool timerOn = false;

    [SerializeField] private TMP_Text timerText;

    public string LevelName;

    void Start()
    {
        timerOn = true;
    }

    void Update()
    {
        if (timerOn)
        {
            if (timeLeft >= 1)
            {
                timeLeft -= Time.deltaTime;
                UpdateTimer(timeLeft);
            }
            if(timeLeft < 1)
            {
                timerText.text = 0.ToString();
                timeLeft = 0;
                timerOn = false;
                FimDeJogo();
            }
        }
    }

    private void UpdateTimer(float currentTime)
    {
        float seconds = Mathf.Floor(currentTime % 120);
        timerText.text = seconds.ToString();
    }

    public void FimDeJogo()
    {
        SceneManager.LoadScene(LevelName);
    }
}
