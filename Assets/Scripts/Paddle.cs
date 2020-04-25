using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Paddle : MonoBehaviour
{
    private GameManager manager;
    private BoxCollider2D paddleBoxCollider2D;
    private Rigidbody2D paddleRigidBody2D;

    public bool isPlayer2 = false;
    public float vertSpeed = 2.0f;

    public Vector2 startingPosition = new Vector2(0.0f, 0.0f);

    private void Awake()
    {
        manager = Camera.main.GetComponent<GameManager>();
    }

    private void Start()
    {
        paddleBoxCollider2D = GetComponent<BoxCollider2D>();
        paddleRigidBody2D = GetComponent<Rigidbody2D>();

        paddleRigidBody2D.isKinematic = true;

        ResetPosition();
    }

    private void FixedUpdate()
    {
        paddleRigidBody2D.velocity = new Vector2(0.0f, getVertical() * vertSpeed);
    }

    public void ResetPosition()
    {
        gameObject.transform.position = startingPosition;
    }

    public void Shrink()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        gameObject.transform.localScale = new Vector3(currentScale.x, currentScale.y - 0.1f, currentScale.z);
    }

    private float getHorizontal()
    {
        if (!isPlayer2)
        {
            return Input.GetAxisRaw("Horizontal P1");
        }
        else
        {
            return Input.GetAxisRaw("Horizontal P2");
        }
    }

    private float getVertical()
    {
        if (!isPlayer2)
        {
            return Input.GetAxisRaw("Vertical P1");
        }
        else
        {
            return Input.GetAxisRaw("Vertical P2");
        }
    }
}
