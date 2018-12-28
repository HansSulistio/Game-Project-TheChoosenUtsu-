using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimOneInfinite : MonoBehaviour {

    public GameObject EnemyBullet;
    public Transform shotpoint;
    public float startTimeBtwShots;

    private float timeBtwShots;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwShots <= 0)
        {

            FireToPlayer();
            timeBtwShots = startTimeBtwShots;
            
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }

    void FireToPlayer()
    {
        GameObject player = GameObject.Find("Player");

        if (player != null)
        {
            GameObject bullet = Instantiate(EnemyBullet, shotpoint.position, transform.rotation);



            Vector2 direction = player.transform.position - bullet.transform.position;

            bullet.GetComponent<AimPlayer>().setDirection(direction);
        }

    }
}
