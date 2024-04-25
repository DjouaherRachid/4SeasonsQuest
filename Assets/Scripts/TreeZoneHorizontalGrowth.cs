using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeZoneHorizontalGrowth : MonoBehaviour
{   
    public GameObject bucket;
    public Animator animator; 
    public Renderer deadTree;
    public Renderer cherryTree;

    private bool isBucketInside = false;
    private static readonly int RootGrowth = Animator.StringToHash("RootGrowth");
        
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == bucket)
        {   
            // Vérifier si le seau est rempli d'eau
            if(bucket.GetComponent<BucketBehaviour>().isFull == true)
            {
                isBucketInside = true;
                CheckAnimationTrigger();   
            }
        }
    }
    
    private void CheckAnimationTrigger()
    {
        if (isBucketInside)
        {
            animator.SetTrigger(RootGrowth);
            deadTree.enabled = false;
            cherryTree.enabled = true;
            bucket.SetActive(false);
        }
    }
}