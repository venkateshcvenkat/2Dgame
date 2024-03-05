using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
   
    public void playbutton()
    {
        SceneManager.LoadScene(1);
    }
    public void Quitbutton()
    {
        Application.Quit();
    }
}
