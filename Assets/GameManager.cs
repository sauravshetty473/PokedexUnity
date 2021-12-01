using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    private void Awake()
    {
        instance = this;

        SceneManager.LoadSceneAsync((int)SceneEnum.START, LoadSceneMode.Additive);
    }



    public void LoadGame(int now, int next)
    {
        SceneManager.UnloadSceneAsync(now);
        SceneManager.LoadSceneAsync(next);
    }
}
