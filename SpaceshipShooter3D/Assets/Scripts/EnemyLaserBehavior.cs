using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLaserBehavior : MonoBehaviour
{
    private Rigidbody laserPB;
    public float speed = 3.0f;
    private float lifeDuration = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        laserPB = GetComponent<Rigidbody>();
        Destroy(gameObject, lifeDuration);
    }

    // Update is called once per frame
    void Update()
    {
        laserPB.AddForce(transform.forward * -speed, ForceMode.Impulse);
    }
}
