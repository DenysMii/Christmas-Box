using UnityEngine;

public class ToggleFullscreen : MonoBehaviour
{
    const int WIDTH_WINDOWED = 1024;
    const int HEIGHT_WINDOWED = 576;

    const int WIDTH_FULL = 1920;
    const int HEIGHT_FULL = 1080;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Screen.fullScreen)
                Screen.SetResolution(WIDTH_WINDOWED, HEIGHT_WINDOWED, false);
            else
                Screen.SetResolution(WIDTH_FULL, HEIGHT_FULL, true);
        }
    }

    private void OnApplicationQuit()
    {
        Screen.SetResolution(WIDTH_FULL, HEIGHT_FULL, true);
    }
}
