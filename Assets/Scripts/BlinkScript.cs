using UnityEngine;
using System.Collections;

public class BlinkScript : MonoBehaviour {
	public float tempo;
	Collider2D colisor;
	NaveScript scriptNave;
	TiroScript scriptTiro;
	Renderer render;
	const int VEZES = 10;

	void Start () {
		colisor = GetComponent<Collider2D>();
		render  = GetComponent<Renderer>();
		scriptNave = GetComponent<NaveScript>();
		scriptTiro = GetComponentInChildren<TiroScript>();
	}
	
	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.gameObject.tag.Equals("Inimigo")){
			StartCoroutine(Blink(tempo));
		}
	}

	void ToggleComponentes(){
		colisor.enabled = !colisor.enabled;
		scriptNave.enabled = !scriptNave.enabled;
		scriptTiro.enabled = !scriptTiro.enabled;
	}

	IEnumerator Blink(float temp){
		ToggleComponentes();
		for (int i=0; i < VEZES; i++){
			render.enabled = false;
			yield return new WaitForSeconds(temp);
			render.enabled = true;
			yield return new WaitForSeconds(temp);
		}
		ToggleComponentes();
	}
}
