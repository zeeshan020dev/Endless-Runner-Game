using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;

    public static bool isGameStarted;
    public GameObject startingText;

    public static int numberofCoins;
    public TextMeshProUGUI coinsText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1.0f;
        isGameStarted = false;
        numberofCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        coinsText.text = "Coins: " + numberofCoins;
        if (!isGameStarted)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isGameStarted = true;

                // Check if instance exists before calling it
                if (AudioManager.instance != null)
                {
                    AudioManager.instance.PlaySound("MainTheme");
                }
                else
                {
                    Debug.LogError("AudioManager instance is missing!");
                }

                Destroy(startingText);
            }
        }
    }
}
