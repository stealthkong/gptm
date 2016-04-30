using UnityEngine;
using System.Collections;

public class openCutScript3 : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;
	public GameObject text3;
	
	// Use this for initialization
	void Start () {
		
		text1.SetActive(false);
		text2.SetActive(false);
		text3.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.anyKey){
			text1.SetActive(true);
			text2.SetActive(true);
			text3.SetActive(true);

		}
		if (Input.GetKey(KeyCode.Space)) {
			Application.LoadLevel(4);
		}
		
		
	}
}