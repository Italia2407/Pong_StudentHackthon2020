﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Paddle p1;
    public Paddle p2;
    public GoalPost g1;
    public GoalPost g2;
    public BallController ball;

    public int winningScore = 7;

    public bool hardMode = false;

    public int Player1Score { get; private set; }
    public int Player2Score { get; private set; }


    public void P1Score()
    {
        Player1Score++;
        Reset();

        if (hardMode)
            p2.Shrink();
        else
            p1.Shrink();
    }
    public void P2Score()
    {
        Player2Score++;
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

}
