using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Paddle p1;
    public Paddle p2;
    public GoalPost g1;
    public GoalPost g2;
    public BallController ball;

    private int player1Score = 0;
    private int player2Score = 0;

    public int winningScore = 7;

    public int Player1Score { get => player1Score; }
    public int Player2Score { get => player2Score; }


    public void P1Score()
    {
        player1Score++;
        Reset();
    }
    public void P2Score()
    {
        player2Score++;
        Reset();
    }

    private void Reset()
    {
        p1.ResetPosition();
        p2.ResetPosition();
    }

}
