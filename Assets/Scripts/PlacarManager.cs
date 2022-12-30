using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlacarManager : MonoBehaviour {
	Text txtPlacar;
	public static int placar = 0;

	void Start(){
		txtPlacar = GetComponent<Text>();
	}

	void Update () {
		txtPlacar.text = "Placar: " + placar;
	}
}
