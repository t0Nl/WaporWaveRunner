using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void ExitApplication()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
