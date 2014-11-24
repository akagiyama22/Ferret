using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {

	[SerializeField]
	private GameObject ballet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		if (GUI.Button(new Rect(10, 10, 50 , 40), "Shot")) {
			Debug.Log("Shot!!");
			iTweenEvent.GetEvent(ballet, "shot").Play();
		}
		// if (GUI.Button(new Rect(10, 10, 50 , 40), "Shot")) {

		// }
	}
}
