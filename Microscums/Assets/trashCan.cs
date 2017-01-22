using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashCan : MonoBehaviour {
    public Vector2 origin, newPos;
	// Use this for initialization
	void Start () {
        this.origin = this.transform.position;
        this.newPos = this.transform.FindChild("newPos").transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void upTrashCan()
    {
        this.transform.position = this.newPos;
    }

    public void downTrashCan()
    {
        this.transform.position = this.origin;
    }
}
