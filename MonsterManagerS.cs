using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManagerS : MonoBehaviour
{
    public GameObject Turtle_prefab;

    public float turtleSpawnTime = 0.6f;

    private float elapsedTime = 0f;

    //private float totalTime = 0f;

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        //totalTime += Time.deltaTime;

        if (gameManager.wave2 == true && elapsedTime >= turtleSpawnTime)
        {
            float x_random = Random.Range(-9.5f, 9.5f);

            Instantiate(Turtle_prefab, new Vector3(x_random, 0.1f, -10f), Quaternion.Euler(0, 0, 0));

            elapsedTime = 0f;
        }
        if (gameManager.wave1 == false && gameManager.wave2 == false)
        {
            this.gameObject.SetActive(false);
        }
        //else if (gameManager.wave2 == true)
        //{
        //    this.gameObject.SetActive(true);
        //}
    }

    //public void SetActiveFalse()
    //{
    //    this.gameObject.SetActive(false);
    //}
}
