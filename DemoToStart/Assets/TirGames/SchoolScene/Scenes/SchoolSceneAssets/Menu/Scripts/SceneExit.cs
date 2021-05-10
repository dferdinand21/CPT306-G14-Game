using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneExit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("escape")) {
			SceneManager.LoadScene("SchoolSceneMenu");
		}
	}
}
