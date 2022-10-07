using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextStage : MonoBehaviour
{
    //Variables
    private int NextScene;

    //get scene
    private void Start()
    {
        NextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    //load next scene in the build order
    public void OnTriggerEnter(Collider collision)
    {
            SceneManager.LoadScene(NextScene);
    }
}
