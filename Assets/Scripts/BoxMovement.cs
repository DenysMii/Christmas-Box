using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    public GameObject eventSystem;

    public float sideMovement = 20f;

    private float timeRange;
    private Vector3 pos;
    private Vector3 spawnPoints;
    private void Start()
    {
        
        pos = transform.position;
        spawnPoints = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.pixelWidth, Camera.main.pixelHeight, 0));
    }
    void Update()
    {
        timeRange = eventSystem.GetComponent<Gameplay>().spawningFrequency;
        if (!FindAnyObjectByType<Gameplay>().gameIsStopped && !FindAnyObjectByType<Gameplay>().gameIsPaused)
        {
            if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && transform.position.x < spawnPoints.x)
            {
                pos.x += sideMovement * Time.deltaTime / timeRange;
            }
            if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && transform.position.x > -spawnPoints.x)
            {
                pos.x -= sideMovement * Time.deltaTime / timeRange;
            }
            transform.position = pos;
        }
        
    }
}
