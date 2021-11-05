using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRB;
    public float speed;
    private float Hinput;
    private float Vinput;
   

    public int playerHealth = 10;

    

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        CheckBoundaries();

        //Testing purposes
        Debug.Log($"{playerHealth}");

        if(playerHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    void MovePlayer()
    {
        Hinput = Input.GetAxis("Horizontal");
        Vinput = Input.GetAxis("Vertical");

        float moveByX = Hinput * speed * Time.deltaTime;
        float moveByY = Vinput * speed * Time.deltaTime;
       

        transform.Translate(moveByX, moveByY, 0f, Space.Self);

        
        //move forward
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }

        //move back
        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);

        }


       

    }

    void CheckBoundaries()
    {
        if (transform.position.x > 13)
        {
            transform.position = new Vector3(13, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -13)
        {
            transform.position = new Vector3(-13, transform.position.y, transform.position.z);
        }

        if (transform.position.y > 7.6f)
        {
            transform.position = new Vector3(transform.position.x, 7.6f, transform.position.z);
        }

        if (transform.position.y < -3)
        {
            transform.position = new Vector3(transform.position.x, -3, transform.position.z);
        }

        if (transform.position.z > 18)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 18);
        }

        if (transform.position.z < -0.5f)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y, -0.5f);
        }

    }


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EnemyLaser")
        {
            playerHealth = playerHealth - 1;
            Debug.Log($"Current Health: {playerHealth}");
        }

        if (collision.gameObject.tag == "Obstacle")
        {
            playerHealth = playerHealth - 1;
            Debug.Log($"Current Health: {playerHealth}");
        }
    }
}
