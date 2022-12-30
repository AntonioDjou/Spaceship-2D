using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseGameScript : MonoBehaviour {
	public Text textoUI;
	private bool pausado;

	void Start () {
		pausado = false;
		textoUI.enabled = false;
	}

	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)){
			pausado = !pausado;
			textoUI.enabled = !textoUI.enabled;
		}

		if (pausado){
				Time.timeScale = 0;
			} else {
				Time.timeScale = 1;
			}
		}
}
