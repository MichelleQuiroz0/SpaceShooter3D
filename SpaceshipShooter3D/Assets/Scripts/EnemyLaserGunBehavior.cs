using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserGunBehavior : MonoBehaviour
{
    public GameObject laserPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FireLaser", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FireLaser()
    {
       
            Instantiate(laserPrefab, transform.position + Vector3.back * 2.0f, transform.rotation);
        
    }
}
