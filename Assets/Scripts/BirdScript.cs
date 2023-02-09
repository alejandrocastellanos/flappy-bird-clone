using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    private LogicScript logic;
    public float flapStrength;
    public bool birdIsAlive = true;
    public AudioSource hitSFX;
    public AudioSource wingSFX;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            wingSFX.Play();
            myRigidbody.velocity = Vector2.up * flapStrength;
        }   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hitSFX.Play();
        logic.gameOver();
        birdIsAlive = false;
    }
}
