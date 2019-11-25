using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene() {

        // declared and defined an integer variable called "CurrentSceneIndex". it is within #
        // SceneManager class, we're saying run the method 
        //  ActiveScene, we need to know whats our current 
        //buildIndex of the scene we are currently on

        int CurrentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(CurrentSceneIndex + 1);
    }

    public void LoadStartScene() {

       
        SceneManager.LoadScene(0); 
    }

    public void QuitScene() {

        Application.Quit();

    }
}
