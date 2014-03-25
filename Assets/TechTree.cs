using UnityEngine;
using System.Collections;

public class TechTree : MonoBehaviour {
	public int DarkSecrets = 0;
	public int Capital = 0;

	void OnGUI () {
		GUI.Label (new Rect (10, 10, 200, 50), "Capital: "+Capital+"\nDark Secrets: "+DarkSecrets);
		if (GUI.Button (new Rect (Screen.width-250,30,200,20), "Your Desk")) {
			Application.LoadLevel("Main");
		}
		if (GUI.Button (new Rect (Screen.width/2-100,Screen.height/2+200,200,20), "Hidden Nests")) {
			print ("Ratmen Tech");
		}
		if (GUI.Button (new Rect (Screen.width/2+100,Screen.height/2+50,200,20), "Deal with the Devil")) {
			print ("Demon Tech");
		}
		if (GUI.Button (new Rect (Screen.width/2+50,Screen.height/2-200,200,20), "Mastermind")) {
			print ("Vampire Tech");
		}
		if (GUI.Button (new Rect (Screen.width/2-250,Screen.height/2-200,200,20), "Dancing Lights")) {
			print ("Faerie Tech");
		}
		if (GUI.Button (new Rect (Screen.width/2-300,Screen.height/2+50,200,20), "Savagery")) {
			print ("Werewolf Tech");
		}
		GUI.enabled = false;
		if (GUI.Button (new Rect (Screen.width/2-100,Screen.height/2-30,200,20), "Victory")) {
			print ("Victory Tech");
		}
	}
}