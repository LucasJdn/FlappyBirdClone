using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    private void Start()
    {
        //uma vez ao inicializar o jogo
        Time.timeScale = 1;
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
