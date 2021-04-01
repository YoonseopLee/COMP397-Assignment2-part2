using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlaneController : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject gameOverPanel;

    void OnTriggerEnter(Collider other)
    {
        // check if the object that triggers a collision is the player
        
        /*
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().EndGame();
            gameOverPanel.SetActive(true);
          

        }
        */
    }
}