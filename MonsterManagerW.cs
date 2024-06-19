using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManagerW : MonoBehaviour
{

    public GameObject Snake_prefab;

    public float snakeSpawnTime = 0.7f;

    private float elapsedTime = 0f;

    //private float totalTime = 0f;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        //totalTime += Time.deltaTime;

        if (gameManager.wave1 == true && elapsedTime >= snakeSpawnTime)
        {
            float z_random = Random.Range(-9.5f, 9.5f);

            Instantiate(Snake_prefab, new Vector3(-10f, 0.1f, z_random), Quaternion.Euler(0, 90, 0));

            elapsedTime = 0f;
        }
        if (gameManager.wave1 == false)
        {
            SetActiveFalse();
        }
    }

    public void SetActiveFalse()
    {
        this.gameObject.SetActive(false);
    }
}
