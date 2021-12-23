using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathEffect : MonoBehaviour
{
	public GameObject deathEffect; 
	public GameObject impactEffect;

	public void FixedUpdate()
	{
		Destroy(deathEffect, 0.4f);
		Destroy(impactEffect, 0.2f);
	}
	

	
}
