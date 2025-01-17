using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterText;
    public Text scoreText;
    public Text highScoreText;

    public int counter = 0;

    void Update()
    {
        counterText.text = counter.ToString();
    }

    public void SetScore()
    {
        if(counter > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", counter);
        }
        highScoreText.text = "High score: " + PlayerPrefs.GetInt("highScore", 0).ToString();
        scoreText.text = "Score: " + counter.ToString();
    }
}
