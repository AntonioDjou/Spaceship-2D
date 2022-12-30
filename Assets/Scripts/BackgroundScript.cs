using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour {
	public float velocScroll;
	public float tamBackground;
	private Vector3 posInicial;

	void Start () {
		posInicial = transform.position;
	}
	
	void Update () {
		float offset = Mathf.Repeat(Time.time*velocScroll
			                       , tamBackground);
		transform.position = posInicial + Vector3.down * offset;
	}
}
