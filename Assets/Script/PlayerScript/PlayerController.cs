using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;            
    public float panSpeed = 20f;
    private Rigidbody2D rb2d;      

    void Start()
    {
        //rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (FreezeAll.current.stop)
        {
            return;
        }

        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
