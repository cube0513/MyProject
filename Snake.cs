using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public float speed = 5.0f;
    private float hp = 10.0f;

    //public UI snakeUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (this.gameObject.transform.position.x >= 10.0f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            hp -= 10.0f;
            if (hp <= 0.0f)
            {
                UI.snakeNum += 1;
                Destroy(this.gameObject);
            }
        }
    }
}
