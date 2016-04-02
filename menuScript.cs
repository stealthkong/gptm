using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menuScript : MonoBehaviour {

	public Button startText;
	public Button godText;
	public Canvas quitMenu;
	public Button exitText;

	// Use this for initialization
	void Start () {

		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		godText = godText.GetComponent<Button> ();
		quitMenu.enabled = false;

	}

	// This is used when the user presses the 'Quit' button	
	public void ExitPress()
	{
		quitMenu.enabled = true;
		startText.enabled = false;
		godText.enabled = false;
		exitText.enabled = false;
	}

	// Used when the user presses the 'No' button on the Quit menu
	public void NoPress()
	{
		quitMenu.enabled = false;
		startText.enabled = true;
		godText.enabled = true;
		exitText.enabled = true;
	}

	// Used when the user pushes the 'Play' button
	public void StartLevel()
	{
		Application.LoadLevel (1);
	}

	// Used when the user pushes the 'God Mode' button
	public void StartGod()
	{
		Application.LoadLevel (1);
	}

	public void ExitGame()
	{
		Application.Quit ();
	}

}
