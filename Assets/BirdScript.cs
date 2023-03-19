using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;


    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

   
    void Update()
    {
        if(birdIsAlive==false)
        {
            logic.gameOver();
            GameObject.Destroy(this.gameObject);
        }
        if(Input.GetKeyDown(KeyCode.Space)==true&& birdIsAlive==true)
        {
          myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if(transform.position.y>17 || transform.position.y<-17)
        {
            birdIsAlive = false; 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        birdIsAlive = false;
    }
}
