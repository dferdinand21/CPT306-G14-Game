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

    public GameState currentGameState = GameState.menu;

    public Canvas menuCanvas;
    public Canvas inGameCanvas;
    public GameObject pausedCanvas;
    public Canvas postgameCanvas;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        currentGameState = GameState.menu;

        pausedCanvas.SetActive(false);
    }

    void SetGameState(GameState newGameState)
    {
        if (newGameState == GameState.menu)
        {
            //setup Unity scene for menu state
            menuCanvas.enabled = true;
            inGameCanvas.enabled = false;
            pausedCanvas.SetActive(false);
            postgameCanvas.enabled = false;
        }
        else if (newGameState == GameState.inGame)
        {
            //setup Unity scene for inGame state
            Time.timeScale = 1;
            menuCanvas.enabled = false;
            inGameCanvas.enabled = true;
            pausedCanvas.SetActive(false);
            postgameCanvas.enabled = false;
        }
        else if (newGameState == GameState.postGame)
        {
            // get time remaining
            //timeRemaining;
            //setup Unity scene for gameOver state
            menuCanvas.enabled = false;
            inGameCanvas.enabled = false;
            pausedCanvas.SetActive(false);
            postgameCanvas.enabled = true;
        }
        else if (newGameState == GameState.paused)
        {
            //setup Unity scene for paused state
            Time.timeScale = 0; // used to pause game, set this to 1 to continue again
            menuCanvas.enabled = false;
            inGameCanvas.enabled = false;
            pausedCanvas.SetActive(true);
            postgameCanvas.enabled = false;
            // currently this works, but cannot activate pause menu somehow
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
        if (Input.GetKeyDown("g"))
        {
            PauseGame();
        }
    }
}
