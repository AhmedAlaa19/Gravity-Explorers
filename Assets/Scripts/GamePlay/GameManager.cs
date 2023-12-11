using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public float timeOffset = 1f;
    bool gameHasEnded = false;

    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }




     public void EndGame()
     {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", timeOffset);

            
        }
     }
     
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
