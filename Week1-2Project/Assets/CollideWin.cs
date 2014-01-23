using UnityEngine;
using System.Collections;

public class CollideWin : MonoBehaviour
{

	private StartCamera targetBall;
	void Start(){
		
		targetBall = GameObject.FindGameObjectWithTag ("Finish").GetComponent<StartCamera> ();

	}

		void OnCollisionEnter (Collision collision)
	{
				if (collision.gameObject.tag == "Player") {
			audio.Play ();
			targetBall.StopCam ();
			Application.LoadLevel ("GameOver");
				}


		}
}
	


