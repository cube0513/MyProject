using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI waveText;

    public TextMeshProUGUI mission1Text;
    public TextMeshProUGUI mission2Text;

    public TextMeshProUGUI timeText;

    public static int mouseNum;
    public static int snakeNum;
    public static int turtleNum;
    public static int skeletonNum;

    private float totalTime = 0f;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        mouseNum = 0;
        snakeNum = 0;
        turtleNum = 0;
        skeletonNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.gameOver != true || gameManager.gameEnd != true)
        {
            totalTime += Time.deltaTime;
            timeText.text = "Time: " + ((int)totalTime / 60) + ":" + ((int)totalTime % 60);

            if (gameManager.wave1 == true)
            {
                waveText.fontSize = 80;
                waveText.text = "들끓는 쥐와 뱀";
                mission1Text.text = " 쥐 20마리 처치: " + mouseNum + "/20";
                mission2Text.text = " 뱀 20마리 처치: " + snakeNum + "/20";
            }
            else if (gameManager.wave2 == true)
            {
                waveText.fontSize = 70;
                waveText.text = "사나운 가시거북과 오싹한 해골";
                mission1Text.text = " 가시거북 15마리 처치: " + turtleNum + "/15";
                mission2Text.text = " 해골 15마리 처치: " + skeletonNum + "/15";
            }
            else if (gameManager.bossWave == true)
            {
                waveText.text = "숲을 점령한 거대 슬라임";
                mission1Text.text = "1분 안에 거대 슬라임 처치";
                mission2Text.text = "";
            }
        }

    }
}
