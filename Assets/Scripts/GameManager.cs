using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool canContinue = false;

    public Paddle p1;
    public Paddle p2;
    public GoalPost g1;
    public GoalPost g2;
    public BallController ball;

    public int winningScore = 7;

    public bool hardMode = false;

    public int Player1Score { get; private set; }
    public int Player2Score { get; private set; }

    private void Update()
    {
        if (canContinue)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }


    public void P1Score()
    {
        Player1Score++;
        if (Player1Score >= winningScore)
        {
            PlayerWins();
            return;
        }
        Reset();

        if (hardMode)
            p2.Shrink();
        else
            p1.Shrink();
    }
    public void P2Score()
    {
        Player2Score++;
        if (Player2Score >= winningScore)
        {
            PlayerWins();
            return;
        }
        Reset();

        if (hardMode)
            p1.Shrink();
        else
            p2.Shrink();
    }

    private void Reset()
    {
        p1.ResetPosition();
        p2.ResetPosition();
        ball.ResetPosition();
    }

    private void PlayerWins()
    {
        canContinue = true;

        p1.enabled = false;
        p2.enabled = false;
        ball.enabled = false;
    }
}
