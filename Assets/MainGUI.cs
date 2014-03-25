using UnityEngine;
using System.Collections;

public class MainGUI : MonoBehaviour {
	//for now initialize these values here
	public int DarkSecrets = 0;
	public int Capital = 0;
	void OnGUI () {
		GUI.Label (new Rect (10, 10, 200, 50), "Capital: "+Capital+"\nDark Secrets: "+DarkSecrets);
		if (GUI.Button (new Rect (Screen.width/2-100,Screen.height/2-40,200,20), "Occult Research")) {
			Application.LoadLevel("Tech Tree");
		}
		if (GUI.Button (new Rect (Screen.width/2-100,Screen.height/2-10,200,20), "Neighborhood Map")) {
			Application.LoadLevel("Buildings");
		}
		if (GUI.Button (new Rect (Screen.width/2-100,Screen.height/2+20,200,20), "Faction Control")) {
			print("Faction Control");
		}
		if (GUI.Button (new Rect (Screen.width-250,Screen.height-70,200,20), "Save Game")) {
			print("Load a game");
		}
		if (GUI.Button (new Rect (Screen.width-250,Screen.height-100,200,20), "Main Menu")) {
			Application.LoadLevel("Title");
		}
	}
}