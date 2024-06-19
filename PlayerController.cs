using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private Rigidbody playerRigidbody;
    public float speed = 8.0f;

    public GameObject Bullet_prefab;
    GameObject myInstance;

    public Animator WizardAnimControl;

    //public static float hp = 50.0f;


    // Start is called before the first frame update
    void Start()
    {
        //playerRigidbody = GetComponent<Rigidbody>();
        WizardAnimControl = GetComponent<Animator>();

        
        WizardAnimControl.SetBool("IsMoved", false);
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            WizardAnimControl.SetBool("IsMoved", true);
           
            moveDirection += Vector3.left;

        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            WizardAnimControl.SetBool("IsMoved", true);
            
            moveDirection += Vector3.right;

        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            WizardAnimControl.SetBool("IsMoved", true);
            
            moveDirection += Vector3.forward;

        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            WizardAnimControl.SetBool("IsMoved", true);
            
            moveDirection += Vector3.back;

        }

        if(Input.anyKey == false)
        {
            WizardAnimControl.SetBool("IsMoved", false);
        }

        if (moveDirection != Vector3.zero)
        {
            //Vector3 newPosition = playerRigidbody.position + moveDirection * speed * Time.deltaTime;
            //playerRigidbody.MovePosition(newPosition);
            transform.Translate(moveDirection.normalized * speed * Time.deltaTime, Space.World);


            Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, speed * 100 * Time.deltaTime);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Vector3 pos = this.gameObject.transform.position;

            myInstance = Instantiate(Bullet_prefab, new Vector3(pos.x, (pos.y + 0.1f), (pos.z)), transform.rotation);
        }
        
        //if (hp <= 0.0f)
        //{
        //    Die();
        //}

    }

    //public void Die()
    //{
    //    this.gameObject.SetActive(false);
    //}
}
