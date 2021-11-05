using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LaserGunBehavior : MonoBehaviour
{

    public GameObject LaserPrefab;

    public AudioSource laserShot;

    public GunControl control;


    private void OnEnable()
    {
        control.GunControlMap.Enable();
    }
    private void OnDisable()
    {
        control.GunControlMap.Disable();
    }

    // Update is called once per frame
    void Awake()
    {
        control = new GunControl();
        control.GunControlMap.Fire.performed += ctx => FireLaser();
        
    }




    void FireLaser()
    {
       
            Instantiate(LaserPrefab, transform.position + Vector3.forward * 2.0f, transform.rotation);
            laserShot.Play();
        
    }
}
