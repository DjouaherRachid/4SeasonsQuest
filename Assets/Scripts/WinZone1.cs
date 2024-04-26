using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class WinZone1 : MonoBehaviour
{    public TextMeshProUGUI  winText;
    public Button winButton;

    private void OnTriggerEnter(Collider other)
    {   
        if (other.CompareTag("Player"))
        {   /*
            winText.gameObject.SetActive(true);
            winButton.gameObject.SetActive(true);
            */
            SceneManager.LoadScene("Level3Automn");
        }
    }
}
