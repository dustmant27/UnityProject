using UnityEngine;
using System.Collections;

public class changeTexture : MonoBehaviour {
	WebCamTexture  webCamTexture;
	void Start(){
		string deviceName = WebCamTexture.devices[0].name;
		
		WebCamDevice[] devices = WebCamTexture.devices;
		string frontCamName="";
		for( int i = 0 ; i < devices.Length ; i++ ) {
			Debug.Log("Device:"+devices[i].name+ "IS FRONT FACING:"+devices[i].isFrontFacing);
			
			if (devices[i].isFrontFacing) {
				frontCamName = devices[i].name;
			}
		}
		webCamTexture = new WebCamTexture(frontCamName, 1280, 720, 15);
	}


	public void DoChange(){


	}

	public void StartCam(){
			
			webCamTexture.Play();
			renderer.material.mainTexture = webCamTexture;
	}

	public void StopCam(){
		webCamTexture.Stop ();
	}

}
