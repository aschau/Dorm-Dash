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

    private float offsetX, offsetY;
    private Vector3 origin;

	// Use this for initialization
	public virtual void Start () {
        this.origin = this.transform.position;
	}
	
	// Update is called once per frame
	public virtual void Update () {
		
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

    public virtual void endDrag()
    {
        this.transform.position = origin;
        this.beingDragged = false;
    }

    public virtual void OnCollisionEnter2D(Collider2D obj)
    {
        if (obj.name == "trashcan" || obj.name == "customer")
        {
            Destroy(gameObject);
        }
    }
}
