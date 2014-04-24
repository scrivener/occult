using UnityEngine;
using System.Collections;

public class TechTree : MonoBehaviour {
	public const string TOOLTIP_HIDDEN_NESTS_TECH = "Cost: 100 Dark Secrets. Hidden Nests: All threat generation from failed or ignored quests is reduced by 30% due to the busy machinations of the Ratmen.";
	public const string TOOLTIP_DEAL_WITH_THE_DEVIL_TECH = "Cost: 100 Dark Secrets. Deal With the Devil: Your capital balance increases passively by 2% per turn.";
	public const string TOOLTIP_MASTERMIND_TECH = "Cost: 100 Dark Secrets. When you gain influence with a faction, you gain 50% bonus influence.";
	public const string TOOLTIP_DANCING_LIGHTS_TECH = "Cost: 100 Dark Secrets. Magic costs for quests are reduced by 15%.";
	public const string TOOLTIP_SAVAGERY_TECH = "Cost: 100 Dark Secrets. All quests with the 'Nature' or 'Combat' tags have their costs reduced by 25% and their rewards increased by 25%.";
	public const string TOOLTIP_VICTORY_TECH = "Cost: 300 Dark Secrets. ???";

	public const int TOOLTIP_WIDTH = 300;
	public const int TOOLTIP_HEIGHT = 200;


	public int DarkSecrets = 0;
	public int Capital = 0;
	void Start () {
		Global.PV= new PermVar();
	}
	void OnGUI () {
		int TOOLTIP_X = (Screen.width / 2) - TOOLTIP_WIDTH/2;
		int TOOLTIP_Y = (Screen.height / 2) + 100;

		GUI.Label (new Rect (10, 10, 200, 50), "Turn: " + PermVar.Turn + "\nCapital: " + PermVar.Capital +
		           "(" + PermVar.CPT + ")" + "\nDark Secrets: " + PermVar.DarkSecrets + "(" + PermVar.DSPT + ")");
		if (GUI.Button (new Rect (Screen.width-250,30,200,20), "Your Desk")) {
			Application.LoadLevel("Main");
		}
		if (GUI.Button (new Rect (Screen.width/2-100,Screen.height/2+200,200,20), new GUIContent("Hidden Nests", TOOLTIP_HIDDEN_NESTS_TECH))) {
			print ("Ratmen Tech");
		}
		if (GUI.Button (new Rect (Screen.width/2+100,Screen.height/2+50,200,20), new GUIContent("Deal with the Devil", TOOLTIP_DEAL_WITH_THE_DEVIL_TECH))) {
			print ("Demon Tech");
		}
		if (GUI.Button (new Rect (Screen.width/2+50,Screen.height/2-200,200,20), new GUIContent("Mastermind", TOOLTIP_MASTERMIND_TECH))) {
			print ("Vampire Tech");
		}
		if (GUI.Button (new Rect (Screen.width/2-250,Screen.height/2-200,200,20), new GUIContent("Dancing Lights", TOOLTIP_DANCING_LIGHTS_TECH))) {
			print ("Faerie Tech");
		}
		if (GUI.Button (new Rect (Screen.width/2-300,Screen.height/2+50,200,20), new GUIContent("Savagery",TOOLTIP_SAVAGERY_TECH))) {
			print ("Werewolf Tech");
		}
		GUI.enabled = false;
		if (GUI.Button (new Rect (Screen.width/2-100,Screen.height/2-30,200,20), new GUIContent("Victory", TOOLTIP_VICTORY_TECH))) {
			print ("Victory Tech");
		}

		// Display the tooltip of the GUI element that is hovered over, if any.
		GUI.Label (new Rect (TOOLTIP_X, TOOLTIP_Y, TOOLTIP_WIDTH, TOOLTIP_HEIGHT), GUI.tooltip);
	}
}