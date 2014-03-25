using UnityEngine;
using System.Collections;

public class TitleGUI : MonoBehaviour {
	
	void OnGUI () {
		if (GUI.Button (new Rect (Screen.width/2-100,Screen.height/2-40,200,20), "New game")) {
			Application.LoadLevel("Main");
		}
		if (GUI.Button (new Rect (Screen.width/2-100,Screen.height/2-10,200,20), "Load game")) {
			print ("Load a game");
		}
		if (GUI.Button (new Rect (Screen.width/2-100,Screen.height/2+20,200,20), "Exit")) {
			Application.Quit();
		}
	}
}