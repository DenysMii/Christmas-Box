using UnityEngine;

public class BallRotation : MonoBehaviour
{
    public GameObject eventSystem;

    private float rotationX;
    private float rotationY;
    private float rotationZ;
    public float maxRotationSpeed = 5.0f;

    public Vector3 rotation;
    public Vector3 velocity;
    System.Random rand = new System.Random();

    void Start()
    {

        rotationX = (float)rand.NextDouble() * maxRotationSpeed;
        rotationY = (float)rand.NextDouble() * maxRotationSpeed;
        rotationZ = (float)rand.NextDouble() * maxRotationSpeed;

        rotation = new Vector3(rotationX, rotationY, rotationZ);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(eventSystem.GetComponent<Gameplay>().gameIsStopped == true)
        {
            GetComponent<Rigidbody>().isKinematic = true;
        }
        else if(eventSystem.GetComponent<Gameplay>().gameIsPaused == true)
        {
            if(velocity.y > GetComponent<Rigidbody>().velocity.y)
            velocity = GetComponent<Rigidbody>().velocity;
            GetComponent<Rigidbody>().isKinematic = true;
        }
        else
        {
            GetComponent<Rigidbody>().isKinematic = false;
            if(velocity.y <GetComponent<Rigidbody>().velocity.y)
            {
                GetComponent<Rigidbody>().velocity = velocity;
            }
            transform.Rotate(rotation);
        }
        
    }
}
