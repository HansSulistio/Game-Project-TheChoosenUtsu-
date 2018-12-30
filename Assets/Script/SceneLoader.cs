using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    private Animator anim;

    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(JumpToScene(sceneIndex));

    }

    IEnumerator JumpToScene(int sceneIndex)
    {
        
        yield return new WaitForSeconds(3.0f);

        SceneManager.LoadScene(sceneIndex);
    }

    // Use this for initialization
    void Start () {
        anim.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
