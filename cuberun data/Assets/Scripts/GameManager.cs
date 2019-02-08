using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    bool GameHasEnded = false;
    public GameObject CompleteLevelUI;
    

    public void EndGame()
    {if(GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game-Over");
            Invoke("Restart", 2f);
        
        }

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel()
    {
        Debug.Log("Level Completed");
        CompleteLevelUI.SetActive(true);
    }
}
