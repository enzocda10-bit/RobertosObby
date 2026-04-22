using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerManager : MonoBehaviour
{
    public static TimerManager Instance { get; private set; }

    [SerializeField] private float timeToPassLevel;
    [SerializeField] private float timerPerItem;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private TextMeshProUGUI coinsText;

    private float currentTime;
    private int coinsCollected;


    private void Awake()
    {
        Instance = this;
        currentTime = timeToPassLevel;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;

        if (currentTime <= 0)
        {
            currentTime = 0;
            SceneManager.LoadScene("LoseScene");
        }

        UpdateTimerText();
    }

    private void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        timeText.text = $"Time {minutes:00}:{seconds:00}";
    }

    public void AddTime()
    {
        currentTime += timerPerItem;
    }

    public void AddCoins()
    {
        coinsCollected++;
        coinsText.text = $"Coins {coinsCollected}";
    }
}
