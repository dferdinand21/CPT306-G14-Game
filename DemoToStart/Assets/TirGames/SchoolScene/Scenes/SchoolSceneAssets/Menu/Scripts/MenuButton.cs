using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {
	public string SceneName;

	public void ButtonClick() {
		SceneManager.LoadScene(SceneName);	
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("escape")) {
			Application.Quit();
		}	
	}
}
