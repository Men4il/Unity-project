using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boobs : MonoBehaviour {
	[SerializedField]
	int IphoneCost;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		IphoneCost = Random.Range(1500, 3000);
		Debug.Log("Your Iphone costs " + IphoneCost + "$");
        Debug.Log("Huli palish, syebi, dura.");
	}
}
