using UnityEngine;
using System.Collections;

public class CollideWin : MonoBehaviour
{

		void OnCollisionEnter (Collision collision)
		{
				if (collision.gameObject.tag == "Player") {
						audio.Play ();
						Application.LoadLevel ("GameOver");
				}


		}
}
	


