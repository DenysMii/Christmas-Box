using UnityEngine;

public class BoxCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            FindAnyObjectByType<Counter>().counter++;
            Destroy(other.gameObject);
        }
    }
}
