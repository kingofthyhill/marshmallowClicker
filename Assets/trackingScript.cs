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
	void textChange () {
		if (player.chunks == 1) {
			chunkTracker.text = "1 Marshmallow";
		} else {
			chunkTracker.text = Mathf.RoundToInt(player.chunks - .49f).ToString () + " Marshmallows";
		}
	}
	void chunkPSChange () {

		chunkPSTracker.text = "per second: " + made.roundToDec(player.chunkPS,1).ToString();
	}
}
