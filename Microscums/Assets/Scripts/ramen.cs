using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramen : foodItem {
    public override void Start()
    {
        base.Start();
        base.stock = 6;
        base.time = 3;
        base.space = 1;
        base.name = "cupNoodle";
        base.occupied = 0;
    }
}
