using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleForward : MonoBehaviour {

    #region private variable
    private float radian = 0f;
    private float speed = 1f;
    private float velocityX = 1f;
    private float velocityY = 1f;
    #endregion

    #region custom function
    public void setRadian(float radian)
    {
        this.radian = radian;
    }

    public void setSpeed(float speed)
    {
        this.speed = speed;
    }

    public void setPos(Vector3 position)
    {
        transform.position = position;
    }

    public float getDegree()
    {
        return radian * (Mathf.PI / 180);
    }
    public void setVelocity()
    {
        velocityX = Mathf.Cos(getDegree()) * speed; //Mathf menerima value berupa degree, sehinga harus di convert dulu radian menjadi degree
        velocityY = Mathf.Sin(getDegree()) * speed;
    }
    
    private Vector2 getUpdatePos()
    {
        Vector2 pos = transform.position;
        pos.x += velocityX * Time.deltaTime;
        pos.y += velocityY * Time.deltaTime;

        return pos;
    }

    private void moveObject()
    {
        transform.position = getUpdatePos();
    }
    #endregion

    #region original function
    private void Start()
    {
        setVelocity();
    }
    private void Update()
    {
        moveObject();
    }
    #endregion
}
