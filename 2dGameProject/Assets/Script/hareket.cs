using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class hareket : MonoBehaviour
{

    public int karakterid;
    Rigidbody2D rb;
    bool havadamý;
    public float moveSpeed = 5f;

    private void Start()
    {
        havadamý = false;
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.D) && karakterid == 1)
        {
            transform.position += new Vector3(0.2f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A) && karakterid == 1)
        {
            transform.position += new Vector3(-0.2f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.W) && karakterid == 1 && havadamý == false)
        {
            rb.AddForce(Vector3.up * 19000);
            havadamý = true;
        }

        if (Input.GetKeyDown(KeyCode.S) && karakterid == 1 && havadamý == true)
        {
            rb.AddForce(Vector3.down * 6500);
        }



        /////////////////////////////////
        if (Input.GetKey(KeyCode.RightArrow) && karakterid == 2)
        {
            transform.position += new Vector3(0.2f, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && karakterid == 2)
        {
            transform.position += new Vector3(-0.2f, 0f, 0f);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && karakterid == 2 && havadamý == false)
        {
            rb.AddForce(Vector3.up * 19000);
            havadamý = true;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && karakterid == 2 && havadamý == true)
        {
            rb.AddForce(Vector3.down * 6500);
        }



    }

    //private void FixedUpdate()
    //{
    //    float moveHorizontal = Input.GetAxis("Horizontal");
    //    float moveVertical = Input.GetAxis("Vertical");
    //    Vector2 movement = new Vector2(moveHorizontal, moveVertical);
    //    //rb.velocity = movement * moveSpeed;
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "zemin")
        {
            havadamý = false;
        }

    }


}
