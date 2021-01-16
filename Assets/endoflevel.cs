using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class endoflevel : MonoBehaviour
{
 
    public void endofgame()
    {
        SceneManager.LoadScene("FPS");
    }

    public void exit()
    {
        Application.Quit();
    }
} 
