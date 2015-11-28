using UnityEngine;
using System.Collections;

public class HeroState : MonoBehaviour {
    public static bool dead_check = false;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.tag == "ammo"){
            dead_check = true;
			Debug.Log ("Game Over");
		}
	}
}
