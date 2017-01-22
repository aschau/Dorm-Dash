using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orders : MonoBehaviour {

    public List<string> order_list = new List<string>();
    public int item_index = 0;

    // Use this for initialization
    void Start () {

        order_list.Add("cupNoodle");
        order_list.Add("cupNoodle");
        order_list.Add("hotPocket");
        order_list.Add("popcorn");
        order_list.Add("tvDinner");
        order_list.Add("hotPocket");
        order_list.Add("tvDinner");
        order_list.Add("popcorn");
        order_list.Add("cupNoodle");
        order_list.Add("cupNoodle");
        order_list.Add("tvDinner");
        order_list.Add("popcorn");

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
