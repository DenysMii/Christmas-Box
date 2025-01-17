using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public GameObject menu;
    public GameObject options;
    public GameObject credits;

    public GameObject pause;

    public void ToMenu()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            menu.SetActive(true);
            options.SetActive(false);
            credits.SetActive(false);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
        
    }
    public void ToOptions()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            menu.SetActive(false);
            options.SetActive(true);
            credits.SetActive(false);
        }
        else
        {
            pause.SetActive(false);
            options.SetActive(true);
        }
    }
    public void ToPause()
    {
        pause.SetActive(true);
        options.SetActive(false);
    }
    public void ToCredits()
    {
        menu.SetActive(false);
        options.SetActive(false);
        credits.SetActive(true);
    }
    public void ToGame()
    {
        SceneManager.LoadScene(1);
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    // Start is called before the first frame update
    public void Exit()
    {
        Application.Quit();
    }
    

    
}
