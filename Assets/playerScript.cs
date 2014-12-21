using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

	public float chunks, chunkPS;
	public float chunkPC = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		chunkPSec ();
	}

	public void attack (){
		chunks += chunkPC;
	}
	public void plusChunkPS (float plusValue) {
		chunkPS += plusValue;
	}
	void chunkPSec (){
		chunks += Time.deltaTime * chunkPS;
	}
}
