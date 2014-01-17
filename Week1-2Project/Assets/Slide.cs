using UnityEngine;
using System.Collections;

public class Slide : MonoBehaviour {
 float speed= 35f;
	float moveUpThreshold= .2f;
	float moveDownThreshold= 1.5f;
	
	 float movex; 
	float movey;
	 float iPx; 
	float iPy;
	
	Vector3 dir = Vector3.zero;
	Vector3 startDir = Vector3.zero;
	Vector3 emptyDir = Vector3.zero;
	void Start(){
		// remap device acceleration axis to game coordinates
		dir.x = -Input.acceleration.y-startDir.x;
		dir.z = -Input.acceleration.x-startDir.y;

		startDir.x = Input.acceleration.x;
		startDir.z = Input.acceleration.y;
		if (startDir.sqrMagnitude > 1) {
			startDir.Normalize();
		}
		// clamp acceleration vector to unit sphere
	
		}

	void Update()
	{
		// we assume that device is held parallel to the ground
		// and Home button is in the right hand
		
		// remap device acceleration axis to game coordinates:
		//  1) XY plane of the device is mapped onto XZ plane
		//  2) rotated 90 degrees around Y axis
		dir.x = Input.acceleration.x;
			dir.z = Input.acceleration.y;

		//if (Input.acceleration.y > emptyDir.y) {

			//	} else {
			//if (Mathf.Abs (Input.acceleration.y) + startDir.z > moveDownThreshold  ) {
			//	dir.z = Input.acceleration.y;
				
		//	}


		
		// clamp acceleration vector to unit sphere
		if (dir.sqrMagnitude > 1)
			dir.Normalize();
		
		// Make it move 10 meters per second instead of 10 meters per frame...
		dir *= Time.deltaTime;
		
		// Move object
		transform.Translate (dir * speed);
	}
}
