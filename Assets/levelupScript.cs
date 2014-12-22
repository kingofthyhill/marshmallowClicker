using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class levelupScript : MonoBehaviour {

	public upgradeScript upgrade;
	public playerScript player;
	public float[] bonus = new float[5]; 
	public float[] cpSec = new float[5]; 
	public Button[] triggers = new Button[15];
	public int[] triggerInt = new int[15];
	public int[] costs = new int[15];
	// Use this for initialization
	void Start () {
		for (int i = 0; i<5; i++) {
			cpSec[i] = upgrade.initalCPSec[i]; 
		} for (int i = 0; i<15; i++) {
			triggerInt[i] = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i<5; i++) {
			upgrade.cPSec[i] = cpSec[i];
		} for (int i = 0; i<15; i++) {
			if (triggerInt[i] == 0){
				buttonAvailable (i);
			} 
		}
	}
	public void trigger (int triggerNum) {
		triggers [triggerNum].interactable = false;
		triggerInt [triggerNum] = 1;
	}
	public void increaseInt (int itemNum) {
		cpSec [itemNum] += bonus [itemNum];
	}
	public void doubleCent (int itemNum) {
		cpSec [itemNum] += cpSec [itemNum];
	}
	public void payUp (int itemNum) {
		player.chunks -= costs [itemNum];
	}
	public void buttonAvailable (int buttonNum) {
		if (costs [buttonNum] <= player.chunks) {
			triggers [buttonNum].interactable = true;
		} else if (costs [buttonNum] > player.chunks) {
			triggers[buttonNum].interactable = false;
		}
	}
}
