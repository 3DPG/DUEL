using UnityEngine;
using System.Collections;

public class Pattern : MonoBehaviour {

	public GameObject ammo;
	public GameObject firepoint;
	public GameObject firepoint1;
	public GameObject firepoint2;
	public GameObject CowBoy;
	public GameObject GunFire;
	public bool limit=false,limit1=false,limit2=false;


	Animator COW_ANI;
	float counter=0.0f;

	// Use this for initialization
	void Start () {
		COW_ANI = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {


		//enemy0
		counter += Time.deltaTime;
		if (counter > 1.0f && !limit) {
			limit=true;
			GameObject new_ammo = (GameObject)Instantiate(ammo);
			Debug.Log("new_ammo " + new_ammo.GetComponent<Collider>().enabled);
			Debug.Log("CowBoy " + CowBoy.GetComponent<Collider>().enabled);
			new_ammo.transform.position=firepoint.transform.position;
			new_ammo.transform.rotation=firepoint.transform.rotation;
			new_ammo.transform.Rotate( new Vector3(90, 0, 0) );
			new_ammo.GetComponent<Rigidbody>().AddForce (firepoint.transform.forward*10000);
			Physics.IgnoreCollision(new_ammo.GetComponent<Collider>(), CowBoy.GetComponent<Collider>());
			Destroy (new_ammo,2.0f);
			GameObject newFire = (GameObject)Instantiate(GunFire);
			newFire.transform.position = firepoint.transform.position;
			Destroy(newFire,0.2f);


		}

		//enemy1

		if (counter > 3.0f && !limit1) {
			limit1=true;
			GameObject new_ammo = (GameObject)Instantiate(ammo);
			new_ammo.transform.position=firepoint1.transform.position;
			new_ammo.transform.rotation=firepoint1.transform.rotation;
			new_ammo.transform.Rotate( new Vector3(90, 0, 0) );
			new_ammo.GetComponent<Rigidbody>().AddForce (firepoint1.transform.forward*10000);
			Physics.IgnoreCollision(new_ammo.GetComponent<Collider>(), CowBoy.GetComponent<Collider>());
			Destroy (new_ammo,2.0f);
			GameObject newFire = (GameObject)Instantiate(GunFire);
			newFire.transform.position = firepoint1.transform.position;
			Destroy(newFire,0.2f);

		}

		//enemy2

		if (counter > 5.0f && !limit2) {
			limit2=true;
			GameObject new_ammo = (GameObject)Instantiate(ammo);
			new_ammo.transform.position=firepoint2.transform.position;
			new_ammo.transform.rotation=firepoint2.transform.rotation;
			new_ammo.transform.Rotate( new Vector3(90, 0, 0) );
			new_ammo.GetComponent<Rigidbody>().AddForce (firepoint2.transform.forward*10000);
			Physics.IgnoreCollision(new_ammo.GetComponent<Collider>(), CowBoy.GetComponent<Collider>());
			Destroy (new_ammo,2.0f);
			GameObject newFire = (GameObject)Instantiate(GunFire);
			newFire.transform.position = firepoint2.transform.position;
			Destroy(newFire,0.2f);

		}

		if (counter > 6.0f) {
			counter = 0.0f;
			limit = false;
			limit1 = false;
			limit2 = false;
		}

	}


}
