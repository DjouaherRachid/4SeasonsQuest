using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeThirstScript : MonoBehaviour
{   
    public Transform spawnTransform;
    public GameObject bucket;
    public GameObject plateform;

    private static readonly int GrowTree = Animator.StringToHash("GrowTree");

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == bucket)
        {   
            // Check if bucket is filled
            if(bucket.GetComponent<BucketBehaviour>().isFull == true)
            {
                Destroy(bucket);
                
                // spawnPlatform
                Instantiate(plateform, spawnTransform.position, spawnTransform.rotation);
            }
        }
    }
}
