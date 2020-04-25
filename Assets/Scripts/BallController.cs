﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Vector2 velocity;
    [SerializeField] private float StartingXVelocity;
    [SerializeField] private float StartingYRange;

    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector2((Random.Range(0, 2) * 2 - 1) *StartingXVelocity, Random.Range(StartingYRange * -1f, StartingYRange));   
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if ((transform.position.y > YBoundary && velocity.y > 0) || (transform.position.y < -1.0f * YBoundary && velocity.y < 0))
        {
            Debug.Log("Out of Bounds");
            velocity = new Vector2(velocity.x, velocity.y * -1f);
        }
        */
        if (transform.position.x < -12.0f)
        {
            Debug.Log("Player 2 wins");
            CreateNewPlayer();
        }
        else if (transform.position.x > 12.0f)
        {
            Debug.Log("Player 1 wins");
            CreateNewPlayer();
        }

        Vector3 newPosition = new Vector3(transform.position.x + Time.deltaTime * velocity.x, transform.position.y + Time.deltaTime * velocity.y, transform.position.z);
        transform.position = newPosition;

    }

    void CreateNewPlayer()
    {
        /*
        Instantiate(gameObject);
        */
        Destroy(gameObject);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.collider;
        if (collider.tag == "Paddle")
        {
            Debug.Log("Is Paddle");
            Vector3 CollisionPoints = collision.contacts[0].point;
            Vector3 ColliderCenter = collider.bounds.center;
            float SquareSize = this.GetComponent<Collider2D>().bounds.size.x;


            if (transform.position.x > (collider.transform.position.x - (collider.bounds.size.x/2)) &&
                (transform.position.x < (collider.transform.position.x + (collider.bounds.size.x / 2))))
            {
                velocity = new Vector2(velocity.x, velocity.y * -1f);
                Debug.Log("Turn back vertical");
            }
            else
            {
                Debug.Log("Turn back horizontal");
                velocity = new Vector2(velocity.x * -1f,velocity.y);
            }
        }
        else if (collider.tag == "Bounds")
        {
            velocity = new Vector2(velocity.x, velocity.y * -1f);
            Debug.Log("Turn back vertical");
        }
    }


}
