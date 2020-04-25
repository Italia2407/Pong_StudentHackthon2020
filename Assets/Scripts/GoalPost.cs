using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class GoalPost : MonoBehaviour
{
    private GameManager manager;
    private BoxCollider2D goalArea;

    public bool isGoal2 = false;

    private void Awake()
    {
        manager = Camera.main.GetComponent<GameManager>();
    }

    private void Start()
    {
        goalArea = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ball")
        {
            if (!isGoal2)
                manager.P2Score();
            else
                manager.P1Score();
        }
    }
}
