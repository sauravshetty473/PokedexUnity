using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StateManager : MonoBehaviour
{

    public int prev = 0;
    public int curr = 0;


    public void goNext(string value)
    {
        string[] mid = value.Split(' ');
        SceneManager.UnloadSceneAsync(int.Parse(mid[0]));
        SceneManager.LoadSceneAsync(int.Parse(mid[1]));

    }


    public void goNextWithPokemon(string value)
    {
        string[] mid = value.Split(' ');
        PokemonInformation.currentIndex = int.Parse(mid[2]);

        SceneManager.UnloadSceneAsync(int.Parse(mid[0]));
        SceneManager.LoadSceneAsync(int.Parse(mid[1]));

    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log(curr);
            Debug.Log(prev);
            SceneManager.UnloadSceneAsync(curr);
            SceneManager.LoadSceneAsync(prev);
        }
    }

}
