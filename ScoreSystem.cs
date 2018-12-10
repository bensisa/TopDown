using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public Text highScoreText;

    public float scoreCount;
    public float highScoreCount;

    public float pointsPerSeconds;

    public bool scoreIncrease;

    //Initialization
    void Start()
    {
        if (!PlayerPrefs.HasKey("High Score"))
        {
            highScoreCount = PlayerPrefs.GetFLoat("High Score");
        }
    }

    //Update called per frame
    void Update()
    {
        if (scoreIncrease)
        {
            scoreCount += pointsPerSeconds * Time.deltaTime;
        }
        if (scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;
            PlayerPrefs.setFloat("High Score", highScoreCount);
        }

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        highScoreText = "High Score: " + Mathf.Round(highScoreCount); 

    }
}