using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.rigidbody.gameObject.layer != LayerMask.NameToLayer("Player"))
        {
            return;
        }

        other.rigidbody.gameObject.transform.parent = gameObject.transform;
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.rigidbody.gameObject.layer != LayerMask.NameToLayer("Player"))
        {
            return;
        }

        other.rigidbody.gameObject.transform.parent = null;
    }
}