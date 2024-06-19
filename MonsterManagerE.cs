using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManagerE : MonoBehaviour
{

    public GameObject Skeleton_prefab;

    public float skeletonSpawnTime = 0.7f;

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

        if (gameManager.wave2 == true && elapsedTime >= skeletonSpawnTime)
        {
            float z_random = Random.Range(-9.5f, 9.5f);

            Instantiate(Skeleton_prefab, new Vector3(10f, 0.1f, z_random), Quaternion.Euler(0, -90, 0));

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
