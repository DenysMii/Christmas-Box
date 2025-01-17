using UnityEngine;

public class ZoomToObject : MonoBehaviour
{
    public GameObject BackGround;
    public GameObject Box;
    // Start is called before the first frame update
    public void ZoomImmediately(GameObject objectToZoom)
    {
        if (objectToZoom != null)
        {
            Vector3 pos = objectToZoom.transform.position;
            Camera.main.orthographicSize = 2;
            Camera.main.transform.position = new Vector3(pos.x, 8, transform.position.z);
            BackGround.transform.localPosition = new Vector3(0, 169, 0);
            Box.SetActive(false);
        }
    }
}
