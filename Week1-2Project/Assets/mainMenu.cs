using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {
	private changeTexture targetBall;
	private int buttonW = 100;
	private int buttonH = 100;
	private float halfScreenW = Screen.width/2;
	public GUISkin customSkin;
	WebCamTexture webCamTexture;
		


	void OnGUI(){
		string latLon;
		LocationInfo location = new LocationInfo();
		GUI.skin = customSkin;
		iPhoneSettings.StartLocationServiceUpdates();
		targetBall = GameObject.FindGameObjectWithTag("Player").GetComponent<changeTexture>();
		//GUI.Box (new Rect ((Screen.width/2) - 50, (Screen.height /2) - 50, 200, 190), "Main Menu");
		if(GUI.Button (new Rect(halfScreenW - (buttonW/2) *4   , Screen.height - 150, 150, buttonH), "Play")){
			targetBall.StopCam  ();
			Application.LoadLevel ("GameLevel");


			//targetBall.doChange ();
		}
		if(GUI.Button (new Rect(halfScreenW + (buttonW/2) *4  , Screen.height - 150, 190, buttonH), "Camera")){
			
			
			targetBall.StartCam  ();

		}
		latLon = iPhoneInput.lastLocation.latitude.ToString()  + ", " +iPhoneInput.lastLocation.longitude.ToString () ;
		
		GUI.Label (new Rect ((Screen.width / 2) - 75,  25, 250, 150), latLon);

		GUI.Label (new Rect ((Screen.width / 2) - 75,  (Screen.height / 2) - 300, 600, 150), "Hit the green box! Stay away from the red and walls!");
	
		
	}
	
	

}
