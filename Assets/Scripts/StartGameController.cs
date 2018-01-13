using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameController : MonoBehaviour {

    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("scn_Game", LoadSceneMode.Single);
    }
}
