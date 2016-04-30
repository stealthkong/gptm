 using System;
 using UnityEngine;
 
 public class pause : MonoBehaviour
 {
	public GameObject PauseUI;

	private bool paused = false;

	//public AudioSource audio;

	public Canvas pauseMenu;

	public Canvas quitMenu;

	void Start(){

		PauseUI.SetActive(false);
		//GetComponent<AudioSource> ().Stop ();
		quitMenu.enabled = false;
		pauseMenu.enabled = false;

	}

	void Update(){
		if (Input.GetButtonDown ("pauseButton")) {
			paused = !paused;
			quitMenu.enabled = false;
			//GetComponent<AudioSource>().Play();
		}

		if (paused) {
			PauseUI.SetActive(true);
			pauseMenu.enabled = true;
			quitMenu.enabled = false;
			Time.timeScale = 0;
		}

		if (!paused) {

			PauseUI.SetActive(false);
			pauseMenu.enabled = false;
			Time.timeScale = 1;
		//	GetComponent<AudioSource> ().Stop ();
		}
	}

	public void Resume(){

		paused = false;
		//GetComponent<AudioSource> ().Stop ();
	}

	public void quitButton(){

		Application.LoadLevel (0);
		//GetComponent<AudioSource> ().Stop ();
	}

	public void quitScreen(){
		pauseMenu.enabled = false;
		quitMenu.enabled = true;

	}
	
 }