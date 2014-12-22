using UnityEngine;
using System.Collections;

public class madeScripts : MonoBehaviour {

	public float roundToDec (float num, int decPlace) {
		float multBy = (float)Mathf.Pow (10, decPlace);
		float final = Mathf.Round(num * multBy) / multBy;
		return (final); 
	}

}
