using UnityEngine;
using System.Collections;

public class CollideWin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

		void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Player") {
			Application.LoadLevel ("FirstScene");
				}

			
		}
	}
	


