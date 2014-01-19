using UnityEngine;
using System.Collections;

public class PlayerLose : MonoBehaviour {
	private changeTexture targetBall;
	private int buttonW = 100;
	private int buttonH = 100;
	private float halfScreenW = Screen.width/2;
	public GUISkin customSkin;
	
	void OnGUI(){
		GUI.skin = customSkin;
		//        targetBall = GameObject.FindGameObjectWithTag("Player").GetComponent<changeTexture>();
		//GUI.Box (new Rect ((Screen.width/2) - 50, (Screen.height /2) - 50, 200, 190), "Main Menu");
		if(GUI.Button (new Rect(halfScreenW -  (buttonW/2)  , Screen.height - 150, 250, buttonH), "Main Menu")){
			Application.LoadLevel ("FirstScene");
			
			
			//targetBall.doChange ();
		}
		
		GUI.Label (new Rect ((Screen.width / 2) - 75,  25, 250, 150), "You lose!");
	}
	
}