using UnityEngine;
using System.Collections;

public class BackgroundTexScript : MonoBehaviour {

	public float velocScroll;
	private Vector2 offsetBase;

	void Start () {
		offsetBase = GetComponent<Renderer>().sharedMaterial.GetTextureOffset("_MainTex");
	}

	void Update () {
		//float y = Mathf.Repeat(Time.time*velocScroll, 1);
		//Vector2 offsetVertical = new Vector2(offsetBase.x, y);
		//GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offsetVertical);
	}

	void OnDisable(){
		GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offsetBase);		
	}
}
