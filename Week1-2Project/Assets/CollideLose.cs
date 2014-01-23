using UnityEngine;
using System.Collections;

public class CollideLose : MonoBehaviour
{
	private StartCamera  targetBall;

		// Use this for initialization
		void Start ()
		{
		
		targetBall = GameObject.FindGameObjectWithTag ("Finish").GetComponent<StartCamera> ();

		}
	
		void OnCollisionEnter (Collision collision)
	{

				if (collision.gameObject.tag == "Player") {
			audio.Play ();
			targetBall.StopCam ();
			Application.LoadLevel ("GameOverLose");
				}
		
		
		}
}
