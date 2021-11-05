using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController2 : MonoBehaviour
{
    private Rigidbody playerRB;
    public float speed;
    private float Hinput;
    private float Vinput;


    public int playerHealth = 1;


    public PlayerControl playerAction;

    // Start is called before the first frame update
    void Start()
    {
        
            playerRB = GetComponent<Rigidbody>();
 
    }
    

    // Update is called once per frame
    void Update()
    {
            Movement();
            CheckBoundaries();

            Debug.Log($"{playerHealth}");

        
            if (playerHealth == 0)
            {
                Debug.Log("PlayerDestroyed!");
                gameObject.SetActive(false);
                
            }
        

        
   
    }

    void Movement()
    {
        Hinput = Input.GetAxis("Horizontal");
        Vinput = Input.GetAxis("Vertical");
        Vector3 movePlayer = new Vector3(Hinput, Vinput, 0f);
        transform.Translate(movePlayer * speed * Time.deltaTime);

    }

    private void OnEnable()
    {

        try 
        { 
            playerAction.Player.Enable();
        }

        catch (NullReferenceException ex)
        {
            return;
        }
    }

    private void OnDisable()
    {

        try
        {
            playerAction.Player.Enable();
        }

        catch (NullReferenceException ex)
        {
            return;
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
            transform.position = new Vector3(transform.position.x, transform.position.y, -0.5f);
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
