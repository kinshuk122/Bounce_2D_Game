using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    float delay = 3f;
    public GameObject completeLevel;

    public void EndGame()
    {
        if(gameHasEnded == false)
        {    
            gameHasEnded = true;
            Invoke("Restart", delay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void CommpleteLevel()
    {
        completeLevel.SetActive(true);
    }
}
