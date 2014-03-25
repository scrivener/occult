using UnityEngine;
using System.Collections;
//This one is going to be pretty different from othe GUIs
//Make a grid of labels
public class BuildingGUI : MonoBehaviour {
	public int DarkSecrets = 0;
	public int Capital = 0;

	void OnGUI () {
		GUI.Label (new Rect (10, 10, 200, 50), "Capital: "+Capital+"\nDark Secrets: "+DarkSecrets);
		GUI.Box (new Rect (Screen.width / 2 - 100, Screen.height / 2 - 100, 100,100), "");
		GUI.Box (new Rect (Screen.width / 2, Screen.height / 2 - 100, 100,100), "");
		GUI.Box (new Rect (Screen.width / 2 - 100, Screen.height / 2, 100,100), "");
		GUI.Box (new Rect (Screen.width / 2 , Screen.height / 2, 100,100), "");
		if (GUI.Button (new Rect (Screen.width - 250, 30, 200, 20), "Your Desk")) {
			Application.LoadLevel ("Main");
			}

	
	}

}