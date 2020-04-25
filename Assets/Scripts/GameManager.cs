using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject p1;
    private GameObject p2;
    private GameObject g1;
    private GameObject g2;
    private GameObject ball;

    private int player1Score = 0;
    private int player2Score = 0;

    public int winningScore = 7;

    public int Player1Score { get => player1Score; }
    public int Player2Score { get => player2Score; }

    public void setPlayer1(GameObject P1) { p1 = P1; }
    public void setPlayer2(GameObject P2) { p2 = P2; }
    public void setGoal1(GameObject G1) { g1 = G1; }
    public void setGoal2(GameObject G2) { g2 = G2; }


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
        p1.GetComponent<Paddle>().ResetPosition();
        p2.GetComponent<Paddle>().ResetPosition();
    }

}
