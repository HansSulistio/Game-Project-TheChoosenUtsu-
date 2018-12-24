using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMoveLeft : MonoBehaviour {

    public float speed = 0.1f;
    public GameObject destroyEffect;
    public float angle;
    // Use this for initialization
    private void Update()
    {
        Vector3 v3 = transform.position;
        v3.x += Time.deltaTime * speed;
        transform.position = v3;
    }

    public void DestroyBullet()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
