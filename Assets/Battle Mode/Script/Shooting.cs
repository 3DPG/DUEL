using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {
	enum GAME_STATE {HIDE, SHOOT};
	GAME_STATE gameState = GAME_STATE.HIDE;
	public GameObject Enemy1,Enemy2,Enemy3,Cowboy;
	float game_time = 0;
	float next_time = 0;
    public bool dead_check;
    public static bool hit_check=false;
    public static bool em0_dead = false;
    public static bool em1_dead = false;
    public static bool em2_dead = false;
    GameObject ammo;

	Animator shoot;
	// Use this for initialization
	void Start () {
		shoot = Cowboy.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        dead_check = HeroState.dead_check;
        game_time += Time.deltaTime;
		if (gameState == GAME_STATE.SHOOT) {
			hit_check = true;
			if(game_time>next_time){
				shoot.SetTrigger ("Hide");
				gameState = GAME_STATE.HIDE;
				hit_check = false;
			}
		}

	}

	void OnGUI(){
		if (gameState == GAME_STATE.HIDE) {
			if (GUI.Button (new Rect (0, 0, 100, 100), "Enemy3")) {
				next_time = game_time + 0.6f;
				gameState = GAME_STATE.SHOOT;
				shoot.SetTrigger ("Shoot");
                if (!dead_check)
                {
                    Destroy(Enemy3, 0.6f);
                    em2_dead = true;
                }
			}
			if (GUI.Button (new Rect (100, 0, 100, 100), "Enemy2")) {
				next_time = game_time + 0.6f;
				gameState = GAME_STATE.SHOOT;
				shoot.SetTrigger ("Shoot");
                if (!dead_check)
                {
                    Destroy(Enemy2, 0.6f);
                    em1_dead = true;
                }
			
			}
			if (GUI.Button (new Rect (200, 0, 100, 100), "Enemy1")) {
				next_time = game_time + 0.6f;
				gameState = GAME_STATE.SHOOT;
				shoot.SetTrigger ("Shoot");
                if (!dead_check)
                {
                    Destroy(Enemy1, 0.6f);
                    em0_dead = true;
                }
			}
		}

		
	}
}
