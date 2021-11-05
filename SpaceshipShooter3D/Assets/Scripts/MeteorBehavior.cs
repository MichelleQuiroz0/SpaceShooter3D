using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorBehavior : MonoBehaviour
{
    public float meteorSpeed;
    private Rigidbody meteorRB;
    // Start is called before the first frame update
    void Start()
    {

        meteorRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveMeteor();
    }

    void MoveMeteor()
    {
        float move = meteorSpeed * Time.deltaTime;
        transform.Translate(Vector3.back * move);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ObjectBoundary")
        {
            Destroy(gameObject);
        }
    }
}
