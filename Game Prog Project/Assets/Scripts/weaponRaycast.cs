using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponRaycast : MonoBehaviour
{
    public Transform firePoint;
    public int damage = 40;
    public LineRenderer lineRenderer;
    public GameObject impactEffect;

    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(ShootRayCast());
        }
    }
  
    IEnumerator ShootRayCast()
    {
        RaycastHit2D hitinfo = Physics2D.Raycast(firePoint.position, firePoint.right);
        
        if (hitinfo) {
            Enemy enemy = hitinfo.transform.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, hitinfo.point);
            //Add Impact Effect Sprite w/ animation.
            Instantiate(impactEffect, hitinfo.point, Quaternion.identity);
            
        } else {
            lineRenderer.SetPosition(0, firePoint.position);
            lineRenderer.SetPosition(1, firePoint.position + firePoint.right * 100);
        }

        lineRenderer.enabled = true;

        yield return new WaitForSeconds(0.10f);

        lineRenderer.enabled = false;
    }

    public void FixedUpdate()
    {
        Destroy(impactEffect,4f);
    }



}
