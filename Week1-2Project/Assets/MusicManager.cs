using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour
{

		public static MusicManager Instance { get; set; }

		void Awake ()
		{
				if (Instance == null) {
						Instance = this;
						DontDestroyOnLoad (this);
						audio.Play ();
				} else {
						Destroy (this);
				}
		}

}
