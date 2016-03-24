using UnityEngine;
using System.Collections;

public class DeathController : MonoBehaviour {
	//public intance variable
	public Transform spawnPoint;
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
		//	GameController.LivesValue -= 1;
				
		} else
			Destroy (other.gameObject);
	}
}
