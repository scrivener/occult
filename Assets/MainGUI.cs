using UnityEngine;
using System.Collections;

public class MainGUI : MonoBehaviour {

	void Start () {
		Global.PV= new PermVar();
	}
	void OnGUI () {
		GUI.Label (new Rect (10, 10, 200, 50), "Turn: " + PermVar.Turn + "\nCapital: " + PermVar.Capital +
		           "(" + PermVar.CPT + ")" + "\nDark Secrets: " + PermVar.DarkSecrets + "(" + PermVar.DSPT + ")");
		if (GUI.Button (new Rect (Screen.width/2-100,Screen.height/2-40,200,20), "Occult Research")) {
			Application.LoadLevel("Tech Tree");
		}
		if (GUI.Button (new Rect (Screen.width/2-100,Screen.height/2-10,200,20), "Neighborhood Map")) {
			Application.LoadLevel("Buildings");
		}
		if (GUI.Button (new Rect (Screen.width/2-100,Screen.height/2+20,200,20), "Faction Control")) {
			Application.LoadLevel("Faction Control");
		}
		if (GUI.Button (new Rect (Screen.width - 250, Screen.height - 130, 200, 20), "Next Turn")) {
						PermVar.Turn=PermVar.Turn+1;
				}
		if (GUI.Button (new Rect (Screen.width-250,Screen.height-70,200,20), "Save Game")) {
			print("Load a game");
		}
		if (GUI.Button (new Rect (Screen.width-250,Screen.height-100,200,20), "Main Menu")) {
			Application.LoadLevel("Title");
		}
	}
}