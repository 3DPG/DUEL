using UnityEngine;
using System.Collections;

public class CameraRotate : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate (new Vector3 (0, 0.1f, 0));

	}
}
