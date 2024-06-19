using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private float totalTime = 0f;

    public bool wave1;
    public bool wave2;
    public bool bossWave;

    public bool gameOver;
    public bool gameEnd;

    public static bool isBossDied;

    // Start is called before the first frame update
    void Start()
    {
        wave1 = true;
        wave2 = false;
        bossWave = false;
        gameOver = false;
        gameEnd = false;
        isBossDied = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameOver || !gameEnd)
        {
            totalTime += Time.deltaTime;

            if (totalTime > 60.0f)
            {
                wave1 = false;
                if (UI.mouseNum >= 20 && UI.snakeNum >= 20)
                {
                    wave2 = true;
                }
                else
                {
                    GameOverSceneChange();
                    gameOver = true;
                }

            }
            if (totalTime > 120.0f)
            {
                wave2 = false;
                if (UI.turtleNum >= 15 && UI.skeletonNum >= 15)
                {
                    bossWave = true;
                }
                else
                {
                    GameOverSceneChange();
                    gameOver = true;
                }
            }
            if(isBossDied == true)
            {
                GameClearSceneChange();
                gameEnd = true;
            }
            if (totalTime > 180.0f)
            {
                GameOverSceneChange();
                gameOver = true;
            }

            if(Input.GetKeyDown(KeyCode.P))
            {
                UI.mouseNum = 20;
                UI.snakeNum = 20;
                UI.turtleNum = 15;
                UI.skeletonNum = 15;
            }


        }
    }
    public void GameOverSceneChange()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void GameClearSceneChange()
    {
        SceneManager.LoadScene("GameClear");
    }

}
