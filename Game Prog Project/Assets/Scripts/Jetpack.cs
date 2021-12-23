using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpack : MonoBehaviour
{
    
    private Rigidbody2D rb;
    private float jumpForce = 40f;
    private float flight = 0f;
    private bool thrusterIsOn;
    [Header("Jet Pack")]
    [Space]
    public Animator animator;
    [SerializeField]
    private GameObject thruster;
    
    private void Start()
    {
        thrusterIsOn = false;
        thruster.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetFloat("Flight", Mathf.Abs(flight));
            thrusterIsOn = true;
            thruster.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            thrusterIsOn = false;
            thruster.SetActive(false);
        }
    }

    private void FixedUpdate()
    {
        switch (thrusterIsOn)
        {
            case true:
                rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Force);
                break;
            case false:
                rb.AddForce(new Vector2(0f, 0f), ForceMode2D.Force);
                break;
        }
    }


}
