using UnityEngine;
using System.Collections;

public class GUIScript : MonoBehaviour {

	[SerializeField]
	private GameObject bullet;
	[SerializeField]
	private GameObject bulletsParent;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		if (GUI.Button(new Rect(10, 10, 50 , 40), "Shot")) {
			Debug.Log("Shot!!");
			// Debug.Log(gameObject;
			GameObject balletOne = (GameObject)Resources.Load("Prefabs/Bullet");
			var tmp = Instantiate(balletOne, gameObject.transform.localPosition, Quaternion.identity) as GameObject;
			tmp.transform.parent = bulletsParent.transform;
			iTweenEvent.GetEvent(tmp.gameObject, "shot").Play();
		}
	}
}
