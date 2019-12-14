using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string level = "level1";
    public void PlayGame ()
    {
      //  Application.LoadLevel(level);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);

    }

    public void QuityGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        //
      //  Application.Quit();

    }
}
