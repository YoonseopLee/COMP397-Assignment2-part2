using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;

    // Start is called before the first frame update
    public void EndGame()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            FindObjectOfType<AudioManager>().Play("fail");
            FindObjectOfType<AudioManager>().Stop("Theme");


            //Invoke("Restart", 5.0f);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        FindObjectOfType<AudioManager>().Play("Theme");
    }
}
