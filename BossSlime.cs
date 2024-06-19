using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossSlime : MonoBehaviour
{
    public float speed = 8.0f;

    private float hp = 300.0f;

    private float elapsedTime = 0f;

    public int newTargetTime;
    public Vector3 Target;

    private NavMeshAgent nav;


    // Start is called before the first frame update
    void Start()
    {
        nav = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= newTargetTime)
        {
            newTarget();
            elapsedTime = 0;
        }
        
    }

    void newTarget()
    {
        float myX = gameObject.transform.position.x;
        float myZ = gameObject.transform.position.z;

        float xPos = myX + Random.Range(-9 - myX, 9 - myX);
        float zPos = myZ + Random.Range(-9 - myZ, 9 - myZ);

        Target = new Vector3(xPos, gameObject.transform.position.y, zPos);
        nav.SetDestination(Target);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            hp -= 10.0f;
            if (hp <= 0.0f)
            {
                GameManager.isBossDied = true;
                Destroy(this.gameObject);
            }
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    PlayerController.hp -= 10.0f;
    //}
}
