using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimOne : MonoBehaviour {

    public GameObject EnemyBullet;

	// Use this for initialization
	void Start () {
        Invoke("FireToPlayer", 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FireToPlayer()
    {
        GameObject player = GameObject.Find("Player");

        if (player != null)
        {
            GameObject bullet = Instantiate(EnemyBullet);

            bullet.transform.position = transform.position;

            Vector2 direction = player.transform.position - bullet.transform.position;

            bullet.GetComponent<AimPlayer>().setDirection(direction);
        }

    }
}
