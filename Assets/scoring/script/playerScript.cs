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
    }


   

}
