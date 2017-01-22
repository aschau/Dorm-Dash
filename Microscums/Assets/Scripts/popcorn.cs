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
        //base.occupied = 0;
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
    }
	
	// Update is called once per frame*/
}
