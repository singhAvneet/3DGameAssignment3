using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tbd : MonoBehaviour {
	

	//public Button StartButton;


	public void StartButtonClick() {
		SceneManager.LoadScene("_Scenes/main");

	}
}
