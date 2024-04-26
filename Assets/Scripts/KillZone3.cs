using UnityEngine;
using UnityEngine.SceneManagement;
public class KillZone3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Level3Automn");
        
    }
}