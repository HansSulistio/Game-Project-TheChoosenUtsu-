using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftThreeWay : MonoBehaviour {

    public GameObject[] a;
    public float startTimeBtwShots;

    private float[] angles = new float[] {195f,180f,165f};
    private float timeBtwShots;
  
    private void initiateBulletShot()
    {
        for (int i = 0; i < a.Length; i++)
        {
            GameObject bullet = Instantiate(a[i], gameObject.transform);
            AngleForward bulletaf = bullet.GetComponent<AngleForward>();

            if (bulletaf != null)
            {
                bulletaf.setPos(gameObject.transform.position);
                bulletaf.setRadian(angles[i % angles.Length]);
                bulletaf.setSpeed(10f);
            }
        }
    }

    void Start () {
        timeBtwShots = startTimeBtwShots;
    }

	void Update () {
        if (timeBtwShots <= 0)
        {
            initiateBulletShot();
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
    
}
