using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameRestart : MonoBehaviour {

	
	// Update is called once per frame
	void ToggleLoad () {
			SceneManager.LoadScene (0);
	}

}
