using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {

    public float speed;
    public float lifetime;

    public GameObject destroyEffect;
    
    // Use this for initialization
    private void Start () {
		Invoke("DestroyBullet",lifetime);
	}
	
	// Update is called once per frame
	private void Update () {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    public void DestroyBullet()
    {
        Instantiate(destroyEffect, transform.position , Quaternion.identity);
        Destroy(gameObject);
    }
}
