using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    private GameManager manager;

    public Text p1ScoreTracker;
    public Text p2ScoreTracker;
    public Text winningScoreManager;

    public Text p1Wins;
    public Text p2Wins;
    public Text continueText;

    private void Awake()
    {
        manager = Camera.main.GetComponent<GameManager>();
    }

    private void Update()
    {
        p1ScoreTracker.text = manager.Player1Score.ToString();
        p2ScoreTracker.text = manager.Player2Score.ToString();
        winningScoreManager.text = manager.winningScore.ToString();

        if (manager.Player1Score >= manager.winningScore)
        {
            p2Wins.gameObject.SetActive(false);
            p1Wins.gameObject.SetActive(true);

            continueText.gameObject.SetActive(true);
        }
        if (manager.Player2Score >= manager.winningScore)
        {
            p1Wins.gameObject.SetActive(false);
            p2Wins.gameObject.SetActive(true);

            continueText.gameObject.SetActive(true);
        }
    }
}
