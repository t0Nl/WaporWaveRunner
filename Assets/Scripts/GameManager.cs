using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool failState = false;
    public GameObject levelCompleteScreen;
    public float restartDelay = 2f;

    public void GameOver ()
    {
        if (failState == false)
        {
            failState = true;
            Invoke("Restart", restartDelay);
        }
    }

    public void EndLevel ()
    {
        levelCompleteScreen.SetActive(true);
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
