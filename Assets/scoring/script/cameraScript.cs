using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;

    public float speed;
    public Rigidbody rb;
    // Use this for initialization
    void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	
	}
}
