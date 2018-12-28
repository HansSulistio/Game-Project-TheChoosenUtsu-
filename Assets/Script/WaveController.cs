using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveController : MonoBehaviour {

    

    [System.Serializable]
    public class WaveEnemy
    {
        public GameObject go;
        public float x,y;
    }

    [System.Serializable]
    public class Wave 
    {
        public List<WaveEnemy> waveenemys = new List<WaveEnemy>();
        public float time;
        public bool isOut = false;
    }

    public List<Wave> waves = new List<Wave>();
    float time = 0;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        foreach (Wave wave in waves)
        {
            if (wave.time <= time && !wave.isOut)
            {
                wave.isOut = true;
                spawnWave(wave);
            }
        }
	}

    public void spawnWave(Wave wave)
    {
        
        foreach (WaveEnemy waveenemy in wave.waveenemys)
        {
            GameObject enemy = Instantiate(waveenemy.go);
            enemy.transform.position = new Vector2(waveenemy.x + transform.position.x, waveenemy.y + transform.position.y);
        }
    }
}
