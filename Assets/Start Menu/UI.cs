using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

	//public
	public int windowWidth = 400;
	public int windowHeight = 150;
	public int button=0;

	//private
	Rect windowRect;
	int windowSwitch = 0 ;
	float alpha = 0 ;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void startgame(){
		Application.LoadLevel ("DUEL_TEST");
	}

	public void QG(){
		windowSwitch = 1;
		alpha=0;
	}

	void GUIAlphaColor_0_To_1()
	{
		if (alpha < 1) {
			alpha += Time.deltaTime;
			GUI.color = new Color (1, 1, 1, alpha);
		}
	}

	void Awake()
	{
		windowRect = new Rect ((Screen.width - windowWidth) / 2, (Screen.height - windowHeight) / 2, windowWidth, windowHeight);
	}

	void OnGUI()
	{
		if (windowSwitch == 1) {
			GUIAlphaColor_0_To_1();
			windowRect = GUI.Window (0, windowRect, QuitWindow, "Quit Window");
		}
	}

	void QuitWindow(int windowID)
	{
		GUI.Label (new Rect (100, 50, 300, 30), "Are you sure to exit?");
		if (GUI.Button (new Rect (80, 110, 100, 20), "Exit")) {
			Application.Quit ();
		}
		if (GUI.Button (new Rect (220, 110, 100, 20), "Cancel")) {
			windowSwitch = 0;
		}
		GUI.DragWindow();
	}
}
