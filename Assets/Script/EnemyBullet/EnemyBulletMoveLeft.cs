using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMoveLeft : MonoBehaviour {

    public float speed;
    public GameObject destroyEffect;

    // Use this for initialization
    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void DestroyBullet()
    {
        Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
