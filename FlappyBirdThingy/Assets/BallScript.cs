using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float bounceStrength;
    public LogicScript logic;
    public Collider2D objectCollider;
    public bool ballCanJump = false;
    public LivesManager lm;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        lm = GameObject.FindGameObjectWithTag("Lives").GetComponent<LivesManager>();
        StartCoroutine(GravityAfterFive());
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && ballCanJump && lm.ballNotStuck) {
            myRigidbody.velocity = Vector2.up * bounceStrength;
        }
        
        if (myRigidbody.position.y < -25) {
            lm.ballNotStuck = false;
            logic.gameOver();
        }
        
        if (myRigidbody.position.x < -20) {
            lm.ballNotStuck = false;
            logic.gameOver();
        }
        
        if (myRigidbody.position.y > 25) {
            lm.ballNotStuck = false;
            logic.gameOver();
        }

    }
    
    IEnumerator GravityAfterFive() {
        yield return new WaitForSeconds(4);
        myRigidbody.gravityScale = 1;
        ballCanJump = true;
    }
    
    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Life") {
            lm.getLife();
        } else {
            lm.resetBall();
        }
    }
    
    //private void OnTriggerEnter(Collider col) {
        //if (col.GetComponent<Collider>().tag == "Life") {
            //logic.getLife();
        //}
    //}
    

    
}
