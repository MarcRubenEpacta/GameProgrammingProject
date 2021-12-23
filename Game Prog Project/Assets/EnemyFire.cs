using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject bolt;
    public Transform Canon;
    public float fireRatep;
    public float fireRatem;
    private float nextFire = 3.0f;
   
    void FixedUpdate()
    {
        if (Time.time > nextFire)
        {
            nextFire = nextFire + Random.Range(fireRatep, fireRatem);
            Instantiate(bolt, Canon.position, Canon.rotation);
        }
    }
}
