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
        //base.occupied = 0;
        base.name = "hotPocket";
    }
    /*public override void endDrag()
    {
        this.beingDragged = false;
        if ((this.transform.position.x < this.trashcanX2) && (this.transform.position.x > this.trashcanX1))
        {
            if ((this.transform.position.y < this.trashcanY2) && (this.transform.position.y > this.trashcanY1))
            {
                if (this.occupied == 12)
                {
                    control.GetComponent<microControl>().space1 = false;
                    control.GetComponent<microControl>().space2 = false;
                    control.GetComponent<microControl>().spaces += 2;
                }
                else if (this.occupied == 23)
                {
                    control.GetComponent<microControl>().space2 = false;
                    control.GetComponent<microControl>().space3 = false;
                    control.GetComponent<microControl>().spaces += 2;
                }
                Destroy(this.gameObject);
            }
        }
        else
        {
            this.transform.position = origin;
        }
    }*/

	
	
}
