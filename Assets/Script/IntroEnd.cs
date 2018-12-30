using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(JumpToScene());
	}
	
    IEnumerator JumpToScene()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("StageOne");
    }

	// Update is called once per frame
	void Update () {
		
	}
}
