using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveLeft : MonoBehaviour {

    public float speed = 5;
	void Update () {
        if (FreezeAll.current.stop)
        {
            return;
        }
        Vector3 v3 = transform.position;
        v3.x += Time.deltaTime * speed;
        transform.position = v3;

    }
}
