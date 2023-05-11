using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreBoard : MonoBehaviour
{

    public Text scoreText;
    public float playerScore;
    public float pointsPerSecond;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0f;
        pointsPerSecond = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)playerScore + " Score";
        playerScore += pointsPerSecond * Time.deltaTime;
    }
}
