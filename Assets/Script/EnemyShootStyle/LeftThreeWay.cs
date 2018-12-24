using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftThreeWay : MonoBehaviour {

    public GameObject[] a;
    public Transform shotpoint;
   
    private float timeBtwShots;
    public float startTimeBtwShots;
  
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (timeBtwShots <= 0)
        {
            for (int i = 0; i < 3; i++)
            {
                Instantiate(a[i],shotpoint.transform);
            }
            timeBtwShots = startTimeBtwShots;
            
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
    
}
