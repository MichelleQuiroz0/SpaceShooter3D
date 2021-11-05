using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float enemySpeed;
    public float enemyHealth;
    private Rigidbody enemyRB;
    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
            MoveEnemy();
        
    }

    void MoveEnemy()
    {
        float move = enemySpeed * Time.deltaTime;
        transform.Translate(Vector3.back * move);

    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Laser")
        {
            LaserBehavior laser = collision.gameObject.GetComponent<LaserBehavior>();
            enemyHealth = enemyHealth - laser.laserDamage;

            if (enemyHealth == 0)
            {
                Destroy(gameObject);
            }
        }

        if (collision.gameObject.tag == "ObjectBoundary")
        {
            Destroy(gameObject);
        }
    }
}
