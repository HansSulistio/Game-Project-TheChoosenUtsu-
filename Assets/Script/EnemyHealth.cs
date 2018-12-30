using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int health;
    public GameObject deadEffect;

    private RippleProcessor camRipple;
    private bool isBoss = false;
    private Animator anim;
    private BossMoveSpots bossmove;


    // Use this for initialization
    void Start() {
        camRipple = Camera.main.GetComponent<RippleProcessor>();



        anim = GetComponentInChildren<Animator>();
        bossmove = GetComponent<BossMoveSpots>();
        if (health >= 50) isBoss = true;
    }

    // Update is called once per frame
    void Update() {
        if(health <= 15 && isBoss)
        {
            setAngryBoss();

            // jika animasi tranform sdh selesai
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Boss-Tri-Transform"))
            {
                bossmove.startWaitTime = 0.5f;
                bossmove.speed = 40f;
            }

        }
    }

    public void damageHealth(int damage)
    {
        health -= damage;
    }

    public bool isHealthLessThanZero()
    {

        if (health <= 0)
        {
            Instantiate(deadEffect, transform.position, Quaternion.identity);
            if (!isBoss)
                camRipple.RippleEffect();
            else
                camRipple.BossRippleEffect();
            
            return true;
        }
        
        return false;

    }

    private void setAngryBoss()
    {
        anim.SetBool("IsAngry", true);
      

    }
}
