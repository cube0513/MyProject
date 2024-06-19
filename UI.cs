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
                waveText.text = "����� ��� ��";
                mission1Text.text = " �� 20���� óġ: " + mouseNum + "/20";
                mission2Text.text = " �� 20���� óġ: " + snakeNum + "/20";
            }
            else if (gameManager.wave2 == true)
            {
                waveText.fontSize = 70;
                waveText.text = "�糪�� ���ðźϰ� ������ �ذ�";
                mission1Text.text = " ���ðź� 15���� óġ: " + turtleNum + "/15";
                mission2Text.text = " �ذ� 15���� óġ: " + skeletonNum + "/15";
            }
            else if (gameManager.bossWave == true)
            {
                waveText.text = "���� ������ �Ŵ� ������";
                mission1Text.text = "1�� �ȿ� �Ŵ� ������ óġ";
                mission2Text.text = "";
            }
        }

    }
}
