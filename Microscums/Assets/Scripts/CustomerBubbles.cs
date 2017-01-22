using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerBubbles : MonoBehaviour {

    private Orders orders;
    public GameObject bubble, food_item, parent;
    public float timeDelay = 2;
    private float keepTrack;
    private string food_type;

    // Use this for initialization
    void Start () {

        keepTrack = 0;
        parent = GameObject.Find(this.gameObject.name);
        orders = FindObjectOfType<Orders>();
    }

    // Update is called once per frame
    void Update () {
        keepTrack -= Time.deltaTime;
        if(keepTrack <= 0 && orders.item_index<12) //may need to change size (i.e. 12) for level
        {
            //print(orders.item_index);
            keepTrack = timeDelay;
            string item = orders.order_list[orders.item_index]; //retrieve item from list
            orders.item_index++; //set index to grab next item in next loops
            if (this.transform.GetChild(0).name != "SpeechBubble(Clone)"){
                GameObject custbub = Instantiate(bubble, transform.position, transform.rotation, parent.transform);
                custbub.transform.SetAsFirstSibling();
            }
            if (item == "cupNoodle") {
                food_type = "cupNoodle";
                this.transform.GetChild(1).gameObject.SetActive(true);
                List<int> to_set = new List<int> { 2, 3, 4 };
                set_others_to_false(to_set);
            }
            if (item == "hotPocket")
            {
                food_type = "hotPocket";
                this.transform.GetChild(2).gameObject.SetActive(true);
                List<int> to_set = new List<int> { 1, 3, 4 };
                set_others_to_false(to_set);
            }
            if (item == "popcorn")
            {
                food_type = "popcorn";
                this.transform.GetChild(3).gameObject.SetActive(true);
                List<int> to_set = new List<int> { 1, 2, 4 };
                set_others_to_false(to_set);
            }
            if (item == "tvDinner")
            {
                food_type = "tvDinner";
                this.transform.GetChild(4).gameObject.SetActive(true);
                List<int> to_set = new List<int> { 1, 2, 3 };
                set_others_to_false(to_set);
            }
        }
	}

    void set_others_to_false(List<int> to_set)
    {
        for(int i = 0; i < 3; i++)
        {
            this.transform.GetChild(to_set[i]).gameObject.SetActive(false);
        }
    }

}
