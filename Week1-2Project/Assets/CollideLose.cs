using UnityEngine;
using System.Collections;

public class CollideLose : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		void OnCollisionEnter (Collision collision)
		{

				if (collision.gameObject.tag == "Player") {
						audio.Play ();
						Application.LoadLevel ("GameOverLose");
				}
		
		
		}
}
