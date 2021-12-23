using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player : MonoBehaviour
{

	public int maxHealth = 200;
	public int currentHealth;

	public HealthBar healthBar;


    void Start()
    {
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.CompareTag("Enemy"))
		{
			TakeDamage(20);
		}

		if (currentHealth == 0)
		{
			SceneManager.LoadScene("MainGame");
		}
	}

	void TakeDamage(int damage)
	{
		currentHealth -= damage;
		healthBar.SetHealth(currentHealth);
	}

	
}
