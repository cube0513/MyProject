using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    public GameManager gameManager;

    public GameObject Boss_prefab;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.bossWave == true)
        {
            float z_random = Random.Range(-9.0f, 9.0f);
            float x_random = Random.Range(-9.5f, 9.5f);

            Instantiate(Boss_prefab, new Vector3(x_random, 0.1f, z_random), Quaternion.identity);
            this.gameObject.SetActive(false);
        }
        
    }
}
