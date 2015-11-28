using UnityEngine;
using System.Collections;

public class HeroState : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.tag == "ammo"){
			Debug.Log ("Game Over");
		}
	}
}
