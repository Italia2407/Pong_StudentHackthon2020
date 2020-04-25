using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Vector2 velocity;

    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector2((Random.Range(0, 2) * 2 - 1) * 5.0f, Random.Range(-2.0f, 2.0f));   
    }

    // Update is called once per frame
    void Update()
    {
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
        else if (transform.position.y >7.0f || transform.position.y < -7.0f)
        {
            Debug.Log("Out of Bounds");
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


}
