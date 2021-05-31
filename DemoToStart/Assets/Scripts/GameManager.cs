using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    menu,
    inGame,
    paused,
    postGame
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameState currentGameState = GameState.menu();

    public Canvas menuCanvas;
    public Canvas inGameCanvas;
    public Canvas pausedCanvas;
    public Canvas postgameCanvas;

    private void Awake()
    {
        instance = this;
    }

    void SetGameState(GameState newGameState)
    {
        if (newGameState == GameState.menu)
        {
            //setup Unity scene for menu state
            menuCanvas.enabled = true;
            inGameCanvas.enabled = false;
            pausedCanvas.enabled = false;
            postgameCanvas.enabled = false;
        }
        else if (newGameState == GameState.inGame)
        {
            //setup Unity scene for inGame state
            Time.timeScale = 1;
            menuCanvas.enabled = false;
            inGameCanvas.enabled = true;
            pausedCanvas.enabled = false;
            postgameCanvas.enabled = false;
        }
        else if (newGameState == GameState.postGame)
        {
            // get time remaining
            //timeRemaining;
            //setup Unity scene for gameOver state
            menuCanvas.enabled = false;
            inGameCanvas.enabled = false;
            pausedCanvas.enabled = false;
            postgameCanvas.enabled = true;
        }
        else if (newGameState == GameState.paused)
        {
            //setup Unity scene for paused state
            Time.timeScale = 0;
            menuCanvas.enabled = false;
            inGameCanvas.enabled = false;
            pausedCanvas.enabled = true;
            postgameCanvas.enabled = false;
        }

        currentGameState = newGameState;
    }

    void StartGame()
    {

        SetGameState(GameState.inGame);
    }

    void PauseGame()
    {

        SetGameState(GameState.paused);
    }

    public void BackToMenu()
    {
        SetGameState(GameState.menu);

        // restart the scene
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


    }

    // Update is called once per frame
    void Update()
    {
        if (currentGameState == GameState.inGame && Input.GetKeyDown("space"))
        {
            PauseGame();
        }
    }
}
