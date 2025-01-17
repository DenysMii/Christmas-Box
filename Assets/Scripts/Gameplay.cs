using UnityEngine;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour
{
    System.Random rand = new System.Random();
    public GameObject spawnBall;

    public GameObject pauseMenu;
    public GameObject optionsMenu;
    public GameObject gameOverMenu;

    public GameObject counter;
    public GameObject score;

    public float spawningFrequency = 1.0f;
    public float timerBetweenSpawning = 0.0f;

    public bool gameIsStopped = false;
    public bool gameIsPaused = false;

    private void Update()
    {
        if (!gameIsStopped && !gameIsPaused)
        {
            if (timerBetweenSpawning > spawningFrequency)
            {
                spawningFrequency -= 0.01f;
                timerBetweenSpawning = 0.0f;
                Spawn();
            }
            else
            {
                timerBetweenSpawning += Time.deltaTime;
            }
        }
        if(Input.GetKeyDown(KeyCode.Escape) && !gameIsStopped)
        {
            if(gameIsPaused)
            {
                Continue();
            }
            else
            {
                Pause();
            }
            
        }
            
    }
    public void Spawn()
    {
        GameObject newBall = Instantiate(spawnBall);
        newBall.GetComponent<BallRotation>().eventSystem = gameObject;
    }
    public void GameOver(GameObject objectToZoom)
    {
        gameIsStopped = true;
        Camera.main.GetComponent<ZoomToObject>().ZoomImmediately(objectToZoom);
        Invoke("GameOverShow", 1);
    }
    public void GameOverShow()
    {
        counter.GetComponent<Counter>().SetScore();
        counter.SetActive(false);
        gameOverMenu.SetActive(true);

    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        gameIsPaused = true;
    }
    
    public void Continue()
    {
        pauseMenu.SetActive(false);
        optionsMenu.SetActive(false);
        gameIsPaused = false;
    }

}
