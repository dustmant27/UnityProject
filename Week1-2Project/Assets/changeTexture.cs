using UnityEngine;
using System.Collections;

public class changeTexture : MonoBehaviour {
	void Start()
	{
				doChange ();
		}
	public void doChange(){
//		string deviceName = WebCamTexture.devices[0].name;
//		
//		WebCamDevice[] devices = WebCamTexture.devices;
//		string frontCamName="";
//		for( int i = 0 ; i < devices.Length ; i++ ) {
//			Debug.Log("Device:"+devices[i].name+ "IS FRONT FACING:"+devices[i].isFrontFacing);
//			
//			if (devices[i].isFrontFacing) {
//				frontCamName = devices[i].name;
//			}
//		}
//		WebCamTexture  webCamTexture = new WebCamTexture(frontCamName, 1280, 720, 30);
//		
//		webCamTexture.Play();
//		renderer.material.mainTexture = webCamTexture;
		var deviceName = WebCamTexture.devices[0].name;
		
		var webCamTexture = new WebCamTexture(deviceName, 1280, 720, 30);
		
		webCamTexture.Play();
		
		renderer.material.mainTexture = webCamTexture;

	}
	public void stopCam(){

		}
}
