using UnityEngine;


public class GroundCollision : MonoBehaviour
{
    public GameObject destroyedVersion;
    public GameObject eventSystem;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Ball")
        {
            GameObject newDestroyed = Instantiate(destroyedVersion, collision.transform.position, collision.transform.rotation);
            newDestroyed.GetComponent<BrokenColor>().SetColor(collision.gameObject.GetComponentInChildren<MeshRenderer>().material.color);
            Destroy(collision.gameObject);
            eventSystem.GetComponent<Gameplay>().GameOver(newDestroyed);
            eventSystem.GetComponent<AudioSource>().Stop();
        }
        
    }
    
}
