using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimPlayer : MonoBehaviour {

    private float speed;
    private Vector2 _direction;
    private bool isReady;

    public void setSpeed(float speed)
    {
        this.speed = speed;
    }

    public void setDirection(Vector2 direction)
    {
        //set direction normalized untuk dapat unit vector
        _direction = direction.normalized;

        isReady = true;
    }

    public void Awake()
    {
        speed = 20f;
        isReady = false;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isReady)
        {
            Vector2 pos = transform.position;

            pos += _direction * speed * Time.deltaTime;

            transform.position = pos;
        }
	}
}
