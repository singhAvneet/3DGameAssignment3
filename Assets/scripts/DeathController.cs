using UnityEngine;
using System.Collections;

public class DeathController : MonoBehaviour {
	//public intance variable
	public Transform spawnPoint;
	public GameController gameController;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
	
		if (other.tag=="Player") {//other.gameObject.CompareTag ("Player")
			Transform playerTranform = other.gameObject.GetComponent<Transform>();
			playerTranform.position = this.spawnPoint.position;
			gameController.LivesValue -= 1;
				
		} else
			Destroy (other.gameObject);
	}
}
