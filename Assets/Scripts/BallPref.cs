using UnityEngine;

public class BallPref : MonoBehaviour
{
    // Start is called before the first frame update

    public MeshRenderer ballRenderer;

    public float x = 0;
    public float y = 0;
    public float z = 19;

    System.Random rand = new System.Random();
    void Start()
    {
        Camera camera = Camera.main;
        Vector3 spawnPoints = camera.ScreenToWorldPoint(new Vector3(camera.pixelWidth, camera.pixelHeight, 0));
        
        transform.position = new Vector3 (x + rand.Next(-(int)spawnPoints.x, (int)spawnPoints.x), y + spawnPoints.y, z);

        Color color;
        switch(rand.Next(0, 6))
        {
            case 0:
                color = Color.red;
                break;
            case 1:
                color = Color.green;
                break;
            case 2:
                color = Color.blue;
                break;
            case 3:
                color = Color.magenta;
                break;
            case 4:
                color = Color.yellow;
                break;
            case 5:
                color = Color.cyan;
                break;
            default:
                color = Color.white;
                break;
            
        }
        ballRenderer.material.color = color;
    }
}
