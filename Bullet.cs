using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 12.0f;
    //private Rigidbody bulletRigidbody;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (this.gameObject.transform.position.z >= 10.0f || this.gameObject.transform.position.z <= -10.0f
            || this.gameObject.transform.position.x>= 10.0f || this.gameObject.transform.position.x <= -10.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
