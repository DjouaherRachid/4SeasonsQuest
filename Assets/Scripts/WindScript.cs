using UnityEngine;

public class WindScript : MonoBehaviour
{
    public Rigidbody playerBody;
    public CharacterController characterController;
    public float windStrength = 1;    
    private void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody  == playerBody)
        {
            Vector3 windDirection = transform.TransformDirection(Vector3.forward);

            characterController.Move(windDirection * windStrength);

            // Debug.Log("It is pushed !");
        }
    }
}