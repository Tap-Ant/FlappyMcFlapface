using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float flapStrength;
    public Rigidbody2D birdRigidbody;
    public logic logic;
    public bool birdIsAlive = true;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            birdRigidbody.velocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
