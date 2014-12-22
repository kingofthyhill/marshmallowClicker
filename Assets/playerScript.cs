using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	public float chunks, chunkPS;
	public float chunkPC = 1;
	public upgradeScript upgrades;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		chunkPS = chunksPerSecond ();
		chunkPSec ();
	}

	public void attack (){
		chunks += chunkPC;
	}
	void chunkPSec (){
		chunks += Time.deltaTime * chunkPS;
	}
	public float chunksPerSecond (){
		float cps = 0;
		for (int i = 0; i<5; i++){
			cps += upgrades.cPSec[i]* upgrades.numOwned[i];
		}
		return cps;
	}
}
