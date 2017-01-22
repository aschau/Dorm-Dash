using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class foodItem : MonoBehaviour {
    public bool beingDragged = false;
    public int stock = 0;
    public int time = 0;
    public int space = 0;
    public float price = 0.0f;
    public string name = "";
    public int occupied = 0;
    public float trashcanX1, trashcanX2, trashcanY1, trashcanY2;

    public GameObject control, mainCamera;
    public Sprite cooked, overCooked;

    private float offsetX, offsetY;
    
    public Vector3 origin;
    private GameObject trashcan;

    public virtual void Awake()
    {
        this.trashcan = GameObject.Find("trashcan");

        this.mainCamera = GameObject.Find("Main Camera");
        //this.control = GameObject.Find("microwaveControl");
        //this.trashcanX1 = this.trashcan.transform.position.x - (this.trashcan.GetComponent<RectTransform>().rect.width / 2);
        //this.trashcanX2 = this.trashcan.transform.position.x + (this.trashcan.GetComponent<RectTransform>().rect.width / 2);
        //this.trashcanY1 = this.trashcan.transform.position.y - (this.trashcan.GetComponent<RectTransform>().rect.height / 2);
        //this.trashcanY2 = this.trashcan.transform.position.y + (this.trashcan.GetComponent<RectTransform>().rect.height / 2);
        this.origin = this.transform.position;
    }

	// Use this for initialization
	public virtual void Start () {
        
        

	}
	
	// Update is called once per frame
	public virtual void Update () {
        if (this.time == 0)
        {
            this.GetComponent<Image>().sprite = cooked;
        }
        if (this.time < 0)
        {
            this.GetComponent<Image>().sprite = overCooked;
        }
	}

    public virtual void beginDrag()
    {
        offsetX = this.transform.position.x - Input.mousePosition.x;
        offsetY = this.transform.position.y - Input.mousePosition.y;
        this.beingDragged = true;
    }

    public virtual void onDrag()
    {
        this.transform.position = new Vector3(Input.mousePosition.x + offsetX, Input.mousePosition.y + offsetY);
    }
    public virtual RaycastHit2D checkHit(GameObject camera)
    {
        return Physics2D.Raycast(new Vector2(camera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition).origin.x, camera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition).origin.y), new Vector2(camera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition).direction.x, camera.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition).direction.y));
    }
    public virtual void endDrag()
    {
        this.beingDragged = false;

        RaycastHit2D hit = checkHit(this.mainCamera);
        if (hit)
        {
           
            Destroy(this.gameObject);
        }
    //    if ((this.transform.position.x < this.trashcanX2) && (this.transform.position.x > this.trashcanX1))
    //    {
    //        if ((this.transform.position.y < this.trashcanY2) && (this.transform.position.y > this.trashcanY1))
    //        {
    //            Debug.Log(this.occupied);
    //            if (this.occupied == 1)
    //            {
    //                this.control.GetComponent<microControl>().space1 = false;
    //                this.control.GetComponent<microControl>().spaces += 1;
    //            }
    //            else if (this.occupied == 2)
    //            {
    //                this.control.GetComponent<microControl>().space2 = false;
    //                this.control.GetComponent<microControl>().spaces += 1;
    //            }
    //            else if (this.occupied == 3)
    //            {
    //                this.control.GetComponent<microControl>().space3 = false;
    //                this.control.GetComponent<microControl>().spaces += 1;
    //            }
    //            else if (this.occupied == 12)
    //            {
    //                this.control.GetComponent<microControl>().space1 = false;
    //                this.control.GetComponent<microControl>().space2 = false;
    //                this.control.GetComponent<microControl>().spaces += 2;
    //            }
    //            else if (this.occupied == 23)
    //            {
    //                this.control.GetComponent<microControl>().space2 = false;
    //                this.control.GetComponent<microControl>().space3 = false;
    //                this.control.GetComponent<microControl>().spaces += 2;
    //            }
    //            else if (this.occupied == 123)
    //            {
    //                this.control.GetComponent<microControl>().space1 = false;
    //                this.control.GetComponent<microControl>().space2 = false;
    //                this.control.GetComponent<microControl>().space3 = false;
    //                this.control.GetComponent<microControl>().spaces += 3;
    //            }
    //            Destroy(this.gameObject);
    //        }
    //    }
    //    else
    //    {
    //        this.transform.position = origin;
    //    }

    }

}
