using UnityEngine;
using TMPro;

public class scoringScript : MonoBehaviour
{
    int highScore;
    int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);
        updateScores();

    }

    public void addScore()
    {
        score++;
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("highScore", highScore);
        }
        updateScores();
    }

    void updateScores()
    {
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
