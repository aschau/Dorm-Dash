using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popcorn : foodItem {

	// Use this for initialization
	public override void Start(){
        base.Start();
        base.space = 2;
        base.time = 3;
        base.name = "popcorn";
	}
	
	// Update is called once per frame
}
