using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int health;
    public GameObject deadEffect;
    private RippleProcessor camRipple;


    // Use this for initialization
    void Start() {
        camRipple = Camera.main.GetComponent<RippleProcessor>();
    }

    // Update is called once per frame
    void Update() {

    }

    public void damageHealth(int damage)
    {
        health -= damage;
    }

    public bool isHealthLessThanZero()
    {
        if (health <= 0)
        {
            Instantiate(deadEffect,transform.position,Quaternion.identity);
            camRipple.RippleEffect();
            return true;
        }
        
        return false;

    }
}
