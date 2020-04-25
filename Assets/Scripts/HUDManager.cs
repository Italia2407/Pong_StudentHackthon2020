using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDManager : MonoBehaviour
{
    private GameManager manager;

    public Text p1ScoreTracker;
    public Text p2ScoreTracker;

    private void Awake()
    {
        manager = Camera.main.GetComponent<GameManager>();
    }

    private void Update()
    {
        p1ScoreTracker.text = manager.Player1Score.ToString();
        p2ScoreTracker.text = manager.Player2Score.ToString();
    }
}
