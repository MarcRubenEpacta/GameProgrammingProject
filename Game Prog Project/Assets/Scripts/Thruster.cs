using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{
    private Rigidbody2D rb;
    private float jumpForce = 40f;
    private bool thrusterIsOn;

    [SerializeField]
    private GameObject thruster;
    // Start is called before the first frame update
    private void Start()
    {
        thrusterIsOn = false;
        thruster.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
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
