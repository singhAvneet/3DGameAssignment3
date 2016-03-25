using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerScript : MonoBehaviour {

  
  
    private int count;
	public GameController gamecontroller;
    void start() {

    
    }

    
    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Pick Up")) {
            other.gameObject.SetActive(false);
			gamecontroller.ScoreValue +=1;
            

        }

		if (other.gameObject.CompareTag("finish")) {
			other.gameObject.SetActive(false);
			gamecontroller.LivesValue=-1;
			gamecontroller.GameOverLabel.text = "You Win";


		}
    }


   

}
