using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody; 
    public float flapStrength;
    public MLogicScript logicScript;

    public bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<MLogicScript>();
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength; 
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("TOUCHED");
        logicScript.gameOver();
        birdIsAlive = false;
    }
}
