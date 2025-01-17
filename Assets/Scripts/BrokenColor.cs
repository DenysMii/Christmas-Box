using UnityEngine;

public class BrokenColor : MonoBehaviour
{
    public void SetColor(Color color)
    {
        MeshRenderer[] mrChildren = gameObject.GetComponentsInChildren<MeshRenderer>();
        foreach (MeshRenderer mr in mrChildren)
        {
            if(mr.gameObject.tag != "Metal")
            {
                mr.material.color = color;
            }
            
        }
    }

}
