using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class upgradeScript : MonoBehaviour {
	
	public int[] initalPrice = new int[5];
	public float[] initalCPSec = new float[5]; 
	public float[] cPSec = new float[5];
	public int[] numOwned = new int[5];
	public Button[] buttons = new Button[5]; 
	public Text[] buttonText = new Text[5];
	public Text[] buttonOwnedDisplay = new Text[5];
	public playerScript player;

	// Update is called once per frame
	void Update () {
		for (int i = 0; i < 5; i++ ){
			buttonAvailable (i);
			buttonName (i);
		}
	}

	public void buttonAvailable (int buttonNum) {
		if (currentPrice (buttonNum) <= player.chunks) {
			buttons [buttonNum].interactable = true;
		} else if (currentPrice (buttonNum) > player.chunks) {
			buttons[buttonNum].interactable = false;
		}
	}

	public void buyButton (int buttonNum) {
		player.chunks -= currentPrice (buttonNum);
		numOwned [buttonNum] += 1;
		buttonName (buttonNum);
		buttonBought (buttonNum);
	}

	int currentPrice (int buttonNum) {
		float price;
		int finalPrice;
		price = initalPrice[buttonNum] * Mathf.Pow(1.15f, (float)numOwned[buttonNum]);
		finalPrice = Mathf.RoundToInt(price);
		return (finalPrice);
	}

	void buttonName (int buttonNum) {
		buttonText[buttonNum].text = currentPrice(buttonNum) + " Marshmallows";
	}
	void buttonBought (int buttonNum){
		buttonOwnedDisplay [buttonNum].text = numOwned [buttonNum].ToString();
	}
}
