using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game : MonoBehaviour {

    public Text scoreText;
    public Text hiScoreText;
    public float scoreCount;
    public float pointsPerSecond;
    public bool scoreIncreasing;

    // Score
    void Update() 
    {
        if (scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
    }

    // Game over
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Collector")
        {
            RestartGame();
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            RestartGame();
        }
    }

    // Restart
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        hiScoreText.text = PlayerPrefs.GetInt("Highscore").ToString();
    }
}