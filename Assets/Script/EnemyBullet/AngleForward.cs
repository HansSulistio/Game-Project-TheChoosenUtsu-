using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleForward : MonoBehaviour {

    // Use this for initialization
    public float angle = 0f;
    public float speed = 5f;
    

    

    public static Vector2 RadianToVector2(float radian)
    {
        return new Vector2(Mathf.Cos(radian), Mathf.Sin(radian));
    }

    public static Vector2 DegreeToVector2(float degree)
    {
        return RadianToVector2(degree * Mathf.Deg2Rad);
    }

    private void Update()
    {
        transform.Translate(DegreeToVector2(angle) *speed * Time.deltaTime);
        
    }
}
