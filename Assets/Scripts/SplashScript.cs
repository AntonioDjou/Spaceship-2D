using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SplashScript : MonoBehaviour {
	
	void Start () {
		StartCoroutine(Temporizador());
	}
	
	IEnumerator Temporizador () {
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene("CenaPrincipal");
	}
}
