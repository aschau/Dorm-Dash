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
    }
    /*public override void endDrag()
    {
        this.beingDragged = false;
        if ((this.transform.position.x < this.trashcanX2) && (this.transform.position.x > this.trashcanX1))
        {
            if ((this.transform.position.y < this.trashcanY2) && (this.transform.position.y > this.trashcanY1))
            {
                if (this.occupied == 1)
                {
                    control.GetComponent<microControl>().space1 = false;
                    control.GetComponent<microControl>().spaces += 1;
                }
                else if (this.occupied == 2)
                {
                    control.GetComponent<microControl>().space2 = false;
                    control.GetComponent<microControl>().spaces += 1;
                }
                else if (this.occupied == 3)
                {
                    control.GetComponent<microControl>().space3 = false;
                    control.GetComponent<microControl>().spaces += 1;
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
