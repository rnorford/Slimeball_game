using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{

//look at the big picture

    public GameObject gameOverScreen;
    
    public AudioSource track;
//    public SlimeSpawnerScript spawn;
//    public LifeSpawner lifeSpawn;
//    public DeathSpawnerScript deathSpawn;
//    public DeathSpawnerScript deathSpawn1;
//    public DeathSpawnerScript deathSpawn2;
    
    //private GameManager theGm;
    
    void Start() {
        Time.timeScale = 1;
        //theGm = FindObjectOfType<GameManager>();
    }
    
    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void gameOver() {
        gameOverScreen.SetActive(true);
        track.volume = 0;
        Time.timeScale = 0;
        //pointsPerSecond = 0f;
    }   //end the game
    
    void Update() {
        //if (numLives < 1) {
            //theGm.GameOver();
        //}


    }
    


}
