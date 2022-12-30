using UnityEngine;
using System.Collections;

public class BalaScript : MonoBehaviour {

	float veloc = 5;

	void Update () {
		transform.Translate(0, veloc * Time.deltaTime, 0);	
	}
		
	void OnTriggerEnter2D(Collider2D col){
		// Destroi a bala quando colidir com o Asteroid
		if (col.tag.Equals("Inimigo")){
			Destroy(gameObject);
		}
	}

	void OnBecameInvisible(){
		// Destroi a bala quando sair da tela
		Destroy(gameObject);
	}
}
