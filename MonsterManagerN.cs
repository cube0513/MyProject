using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManagerN : MonoBehaviour
{
    public GameObject Mouse_prefab;

    public float mouseSpawnTime = 0.5f;

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

        if(gameManager.wave1 == true && elapsedTime >= mouseSpawnTime)
        {
            float x_random = Random.Range(-9.5f, 9.5f);

            Instantiate(Mouse_prefab, new Vector3(x_random, 0.1f, 10.0f), Quaternion.Euler(0, 180, 0));

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
