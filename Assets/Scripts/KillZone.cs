using UnityEngine;
using UnityEngine.SceneManagement;
public class KillZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Level1Scene");
        
    }
}