using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerScript : MonoBehaviour {

	[SerializeField]
	private AudioSource _gameOverSound;
  
    private int count;
	public GameController gamecontroller;
    void start() {

		this._gameOverSound = gameObject.GetComponent<AudioSource> ();
			
    }

    
    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Pick Up")) {
            other.gameObject.SetActive(false);
			gamecontroller.ScoreValue +=1;
			this._gameOverSound.Play ();

        }

		if (other.gameObject.CompareTag("finish")) {
			other.gameObject.SetActive(false);
			gamecontroller.LivesValue=-1;
			gamecontroller.GameOverLabel.text = "you Win";


		}
    }


   

}
