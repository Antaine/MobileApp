using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
 

    void OnTriggerEnter2D(Collider2D co)
    {
         if (co.tag == "Player")
          {
            Debug.Log("Test");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        else
        {
            Debug.Log("Failed " + co.tag);
        }
    }
}
