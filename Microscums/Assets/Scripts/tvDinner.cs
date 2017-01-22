using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tvDinner : foodItem{

	// Use this for initialization
	public override void Start(){
        base.name = "tvDinner";
        base.time = 7;
        base.space = 3;
        base.Start();
        base.occupied = 0;
	}
	
	// Update is called once per frame
}
