using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VidaManager : MonoBehaviour {
	Text textoVida;
	public static int vidas = 3;

	void Start () {
		textoVida = GetComponent<Text>();
	}
	
	void Update () {
		textoVida.text = "Vidas: " + vidas;
	}
}
