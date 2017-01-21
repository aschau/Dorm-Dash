using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotPocket : foodItem {
    //GameObject item = GameObject.FindGameObjectWithTag("hotPocket");
    public override void Start()
    {
        base.Start();
        base.stock = 4;
        base.time = 2;
        base.space = 2;

    }


	
	
}
