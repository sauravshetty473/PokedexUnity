using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartFunction : MonoBehaviour
{

    public void goNext(string value)
    {
        SceneManager.UnloadSceneAsync(2);
        SceneManager.LoadSceneAsync(3);
    }

}
