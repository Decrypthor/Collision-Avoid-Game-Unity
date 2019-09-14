using UnityEngine.SceneManagement;
using UnityEngine;
using System.Threading;

public class GameManager : MonoBehaviour
{
    public int delay = 1000;
    public bool GameHasEnded = false;
    public GameObject LevelCompleteUI;
    public void LevelComplete()
    {
        LevelCompleteUI.SetActive(true);
        //Restart();
    }
    public void GameOver()
    { 
        if(GameHasEnded == false)
            {
                
                GameHasEnded = true;
                Restart();
            }
         
    }
    public void Restart()
    {
        GameHasEnded = false;
        Thread.Sleep(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
