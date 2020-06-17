
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
   
    {
        completeLevelUI.SetActive(true);
    }
    
        public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            UnityEngine.Debug.Log("Game Over");

            Invoke("Restart", restartDelay);



        }

    }   
             void Restart ()
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
             }
    
}
