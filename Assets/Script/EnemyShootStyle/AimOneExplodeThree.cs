using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimOneExplodeThree : MonoBehaviour {

    public GameObject EnemyBullet;
    public GameObject[] EnemyBulletEx;

    private float[] angles = new float[] { 45f, 180f, 315f };
    private GameObject bullet;

    // Use this for initialization
    void Start()
    {
        Invoke("FireToPlayer", 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FireToPlayer()
    {
        GameObject player = GameObject.Find("Player");

        if (player != null)
        {
            bullet = Instantiate(EnemyBullet);

            bullet.transform.position = transform.position;

            Vector2 direction = player.transform.position - bullet.transform.position;

            bullet.GetComponent<AimPlayer>().setDirection(direction);
            Invoke("ExplodeToThree",0.5f);
        }

    }

    void ExplodeToThree()
    {
        if (EnemyBullet)
        {
            

            for (int i = 0; i < EnemyBulletEx.Length; i++)
            {
                GameObject bulletEx = Instantiate(EnemyBulletEx[i]);

                bulletEx.transform.position = transform.position;

                AngleForward bulletaf = bulletEx.GetComponent<AngleForward>();

                if (bulletaf != null)
                {
                    bulletaf.setPos(bullet.transform.position);
                    bulletaf.setRadian(angles[i % angles.Length]);
                    bulletaf.setSpeed(10f);
                }
            }
            Destroy(bullet);

        }
    }
}
