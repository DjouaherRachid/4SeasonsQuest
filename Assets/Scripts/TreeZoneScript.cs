using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeZoneScript : MonoBehaviour
{   public GameObject bucket;
    public GameObject seed;
    public Animator animator; 
    public Material fullMaterial;
    public Material emptyMaterial;

    private bool isSeedInside = false; 
    private bool isBucketInside = false;
    private static readonly int GrowTree = Animator.StringToHash("GrowTree");

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Seed"))
        {
            isSeedInside = true;
            CheckAnimationTrigger();
        }
        else if (collision.gameObject == bucket)
        {   
            // Check if bucket is filled
            if(bucket.GetComponent<BucketBehaviour>().isFull == true)
            {
                isBucketInside = true;
                CheckAnimationTrigger();   
            }
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Seed"))
        {
            isSeedInside = false;
            CheckAnimationTrigger();
        }
        /*
        else if (other.gameObject.CompareTag("Bucket"))
        {
            isBucketInside = false;
            CheckAnimationTrigger();
        }*/
    }
    private void CheckAnimationTrigger()
    {
        if (isSeedInside && isBucketInside)
        {
            animator.SetTrigger(GrowTree);
            seed.SetActive(false);
            bucket.SetActive(false);
        }
    }
}