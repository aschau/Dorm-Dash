using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ramen : foodItem {
    public override void Start()
    {
        base.Start();
        base.stock = 5;
    }
}
