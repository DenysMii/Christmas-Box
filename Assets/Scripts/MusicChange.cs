using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MusicChange : MonoBehaviour
{
    [SerializeField] private string volumeValue;
    public AudioSource audioSource;

    private void Start()
    {
        if (PlayerPrefs.HasKey(volumeValue))
            audioSource.volume = PlayerPrefs.GetFloat(volumeValue);
    }
    public void UpdateMusicVolume()
    {
        audioSource.volume = PlayerPrefs.GetFloat(volumeValue);
    }
    
}