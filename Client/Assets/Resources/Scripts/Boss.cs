using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("DDDDDDDD");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log("on trrigger");

		iTweenEvent.GetEvent(gameObject, "hit").Play();

	}
}

