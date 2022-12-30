using UnityEngine;
using System.Collections;

public class TiroScript : MonoBehaviour {
	
	public GameObject bala;
	AudioSource audio;

	void Start(){
		audio  = GetComponent<AudioSource>();
	}
	void Update () {
		if (Input.GetButtonDown("Jump")){
			audio.Play();
			Instantiate(bala, 
				transform.position, 
				transform.rotation);
		}
	}
}
