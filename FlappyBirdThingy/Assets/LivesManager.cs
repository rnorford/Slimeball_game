using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LivesManager : MonoBehaviour
{

    public Text livesText;
    public float numLives = 0f;
    public bool ballNotStuck = true;
    public LogicScript logic;
    
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = (int)numLives + " Lives";
        
        if (numLives < 0) {
            ballNotStuck = false;
            logic.gameOver();
        }
    }
    
    public void getLife() {
        numLives++;
        //livesText.text = (int)numLives + " Lives";
    }   //linking scripts?
    
    public void resetBall() {
        numLives--;
        //livesText.text = (int)numLives + " Lives";
    }
    
}
