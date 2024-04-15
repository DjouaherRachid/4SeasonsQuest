using UnityEngine;

public class BucketBehaviour : MonoBehaviour
{
    public bool isFull = false;
    public Material fullMaterial;
    public Material emptyMaterial;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Water"))
        {
            isFull = true;

            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null && fullMaterial != null)
            {
                renderer.material = fullMaterial;
            }
        }
        
        /*
        if (collision.gameObject.CompareTag("TreeZone"))
        {
            isFull = false;

            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null && emptyMaterial != null)
            {
                renderer.material = emptyMaterial;
            }
        }*/
    }
}