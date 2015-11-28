using UnityEngine;
using System.Collections;

public class Pattern : MonoBehaviour {

	public GameObject ammo;
	public GameObject firepoint;
	public GameObject firepoint1;
	public GameObject firepoint2;
	public GameObject CowBoy;
	public GameObject Hero;
	public GameObject GunFire;
	public bool limit=false,limit1=false,limit2=false;
	public bool hit_check;
    public bool dead_check;
    public bool em0_dead;
    public bool em1_dead;
    public bool em2_dead;
    int patten = 0;

	Animator COW_ANI;
	float counter=0.0f;

	// Use this for initialization
	void Start () {
		COW_ANI = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		hit_check = Shooting.hit_check;
        dead_check = HeroState.dead_check;
        em0_dead = Shooting.em0_dead;
        em1_dead = Shooting.em1_dead;
        em2_dead = Shooting.em2_dead;
        //enemy0
        counter += Time.deltaTime;
		if (counter > 1.0f && !limit && !dead_check && !em0_dead) {
            patten = 0;
            StartCoroutine(Detection());
            /*	limit=true;
                GameObject new_ammo = (GameObject)Instantiate(ammo);
                Debug.Log("new_ammo " + new_ammo.GetComponent<Collider>().enabled);
                Debug.Log("Hero " + Hero.GetComponent<Collider>().enabled);
                new_ammo.transform.position=firepoint.transform.position;
                new_ammo.transform.rotation=firepoint.transform.rotation;
                new_ammo.transform.Rotate( new Vector3(90, 0, 0) );
                new_ammo.GetComponent<Rigidbody>().AddForce (firepoint.transform.forward*10000);

                if (hit_check==false){
                    Physics.IgnoreCollision(new_ammo.GetComponent<Collider>(),Hero.GetComponent<Collider>());
                }
                Destroy (new_ammo,2.0f);
                GameObject newFire = (GameObject)Instantiate(GunFire);
                newFire.transform.position = firepoint.transform.position;
                Destroy(newFire,0.2f);

        */
        }

		//enemy1

		if (counter > 3.0f && !limit1 && !dead_check && !em1_dead) {
            patten = 1;
            StartCoroutine(Detection());
            

		}

		//enemy2

		if (counter > 5.0f && !limit2 && !dead_check && !em2_dead) {
            patten = 2;
            StartCoroutine(Detection());

		}

		if (counter > 6.0f) {
			counter = 0.0f;
			limit = false;
			limit1 = false;
			limit2 = false;
		}

	}
    IEnumerator Detection()
    {
        if (patten == 0)
        {
            limit = true;
            GameObject new_ammo = (GameObject)Instantiate(ammo);
            Debug.Log("new_ammo " + new_ammo.GetComponent<Collider>().enabled);
            Debug.Log("Hero " + Hero.GetComponent<Collider>().enabled);
            new_ammo.transform.position = firepoint.transform.position;
            new_ammo.transform.rotation = firepoint.transform.rotation;
            new_ammo.transform.Rotate(new Vector3(90, 0, 0));
            new_ammo.GetComponent<Rigidbody>().AddForce(firepoint.transform.forward * 10000);

            GameObject newFire = (GameObject)Instantiate(GunFire);
            newFire.transform.position = firepoint.transform.position;
            Destroy(newFire, 0.2f);
            yield return new WaitForSeconds(0.25f);
            if (hit_check == false)
            {
                Physics.IgnoreCollision(new_ammo.GetComponent<Collider>(), Hero.GetComponent<Collider>());
            }
            Destroy(new_ammo, 2.0f);
        }
        if (patten == 1)
        {
            limit1 = true;
            GameObject new_ammo = (GameObject)Instantiate(ammo);
            new_ammo.transform.position = firepoint1.transform.position;
            new_ammo.transform.rotation = firepoint1.transform.rotation;
            new_ammo.transform.Rotate(new Vector3(90, 0, 0));
            new_ammo.GetComponent<Rigidbody>().AddForce(firepoint1.transform.forward * 10000);
           
            GameObject newFire = (GameObject)Instantiate(GunFire);
            newFire.transform.position = firepoint1.transform.position;
            Destroy(newFire, 0.2f);
            yield return new WaitForSeconds(0.18f);
            if (hit_check == false)
            {
                Physics.IgnoreCollision(new_ammo.GetComponent<Collider>(), Hero.GetComponent<Collider>());
            }
            Destroy(new_ammo, 2.0f);
        }
        if (patten == 2)
        {
            limit2 = true;
            GameObject new_ammo = (GameObject)Instantiate(ammo);
            new_ammo.transform.position = firepoint2.transform.position;
            new_ammo.transform.rotation = firepoint2.transform.rotation;
            new_ammo.transform.Rotate(new Vector3(90, 0, 0));
            new_ammo.GetComponent<Rigidbody>().AddForce(firepoint2.transform.forward * 10000);
           
            GameObject newFire = (GameObject)Instantiate(GunFire);
            newFire.transform.position = firepoint2.transform.position;
            Destroy(newFire, 0.2f);
            yield return new WaitForSeconds(0.16f);
            if (hit_check == false)
            {
                Physics.IgnoreCollision(new_ammo.GetComponent<Collider>(), Hero.GetComponent<Collider>());
            }
            Destroy(new_ammo, 2.0f);
        }


    }
  

}
