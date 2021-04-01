using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public PlayerBehaviour movement;

    public GameObject gameOverPanel;

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.tag == "Enemy")
        {
           // FindObjectOfType<GameManager>().EndGame();
           // gameOverPanel.SetActive(true);
        }
        
    }
}
