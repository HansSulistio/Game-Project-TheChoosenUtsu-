using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    public float cooldown = 5f;
    public float speed = 100f;
    public float duration = 0.5f;

    private float velocityX;
    private float velocityY;
    private float durationTimer = 0f;
    private float cooldownTimer = 0f;

    private float getRadianWithMousePos()
    {
        Vector3 dif = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float radian = Mathf.Atan2(dif.y - transform.position.y, dif.x - transform.position.x);
        return radian;
    }
    private void setVelocityDash()
    {

        velocityX = Mathf.Cos(getRadianWithMousePos()) * speed;
        velocityY = Mathf.Sin(getRadianWithMousePos()) * speed;
    }
    private Vector2 getUpdatedPos()
    {
        Vector2 pos = transform.position;
        pos.x += velocityX * Time.deltaTime;
        pos.y += velocityY * Time.deltaTime;

        return pos;
    }
    private void dash()
    {
        gameObject.transform.position = getUpdatedPos();
    }

    private void updateTimer()
    {
        if (cooldownTimer >= 0)
            cooldownTimer -= Time.deltaTime;
        if (durationTimer >= 0)
            durationTimer -= Time.deltaTime;
    }

    public void setTimer()
    {
        durationTimer = duration;
        cooldownTimer = cooldown;
    }

    void Update()
    {
        if (Input.GetMouseButton(1) && cooldownTimer <= 0)
        {
            setVelocityDash();
            setTimer();
        }

        if (durationTimer > 0)
        {
            dash();
        }

        updateTimer();
    }
}
