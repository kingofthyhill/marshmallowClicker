using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class trackingScript : MonoBehaviour {

	public Text chunkTracker, chunkPSTracker;
	public playerScript player;
	public madeScripts made;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		textChange ();
		chunkPSChange ();
	}
	//Changes the text of the tracker to be how many marshmallows you have.
	void textChange () {
		if (player.chunks == 1) {
			chunkTracker.text = "1 Marshmallow";
		} else if (player.chunks < 1000){
			chunkTracker.text = Mathf.RoundToInt(player.chunks - .49f).ToString () + " Marshmallows";
		} else if (player.chunks < 1000000){
			chunkTracker.text = made.roundToDec(divide(Mathf.RoundToInt(player.chunks - .49f),1000),2).ToString () + "K Marshmallows";
		} else if (player.chunks < 1000000000){
			chunkTracker.text = made.roundToDec(divide(Mathf.RoundToInt(player.chunks - .49f),1000000),2).ToString () + "M Marshmallows";
		} else if (player.chunks < 1000000000000){
			chunkTracker.text = made.roundToDec(divide(Mathf.RoundToInt(player.chunks - .49f),1000000000),2).ToString () + "B Marshmallows";
		} 
	}
	//Changes the text of the tracker to be how many marshmallows per second.
	void chunkPSChange () {

		chunkPSTracker.text = "per second: " + made.roundToDec(player.chunkPS,1).ToString();
	}
	float divide (int num1, int num2){
		return num1 / (float)num2;
		}
}
