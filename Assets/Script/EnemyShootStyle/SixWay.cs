using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SixWay : MonoBehaviour {

    public GameObject[] EnemyBullet;
    public float startTimeBtwShots;

    private float[] angles = new float[] { 0f , 60f , 120f , 180f , 240f , 300f   };
    private float timeBtwShots;

    // Use this for initialization
    void Start () {
        timeBtwShots = startTimeBtwShots;
	}
	
	// Update is called once per frame
	void Update () {
        if (timeBtwShots <= 0)
        {
            InitiateBulletShot();
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }

    private void InitiateBulletShot()
    {
        for (int i = 0; i < EnemyBullet.Length; i++)
        {
            GameObject bullet = Instantiate(EnemyBullet[i]);
            AngleForward bulletaf = bullet.GetComponent<AngleForward>();

            if (bulletaf != null)
            {
                bulletaf.setPos(gameObject.transform.position);
                bulletaf.setRadian(angles[i % angles.Length]);
                bulletaf.setSpeed(10f);
            }
        }
    }

}
