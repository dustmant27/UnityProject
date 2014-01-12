using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {
	private changeTexture targetBall;

	// Use this for initialization
	void OnGUI(){
		string latLon;
		LocationInfo location = new LocationInfo();

		targetBall = GameObject.FindGameObjectWithTag("Player").GetComponent<changeTexture>();
		GUI.Box (new Rect ((Screen.width/2) - 50, (Screen.height /2) - 50, 200, 190), "Main Menu");
		if(GUI.Button (new Rect((Screen.width/2) - 25, (Screen.height /2) - 25, 150, 125), "Play")){
			
			targetBall.doChange ();
		}
		latLon = location.latitude.ToString()  + ", " +location.longitude.ToString() ;
	
		GUI.Label (new Rect ((Screen.width / 2) - 25, (Screen.height - 25), 50, 25), latLon);
		}


}
