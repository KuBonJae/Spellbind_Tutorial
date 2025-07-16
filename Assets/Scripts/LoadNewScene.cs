using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    public void LoadScene()
    {
        if (SceneManager.GetActiveScene().name == "ThreeDimension")
            SceneManager.LoadSceneAsync("TwoDimension");
        else
            SceneManager.LoadSceneAsync("ThreeDimension");
    }
}
