using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerBubbles : MonoBehaviour {

    private Orders orders;
    public GameObject bubble, food_item, parent;
    public float timeDelay = 2;
    private float keepTrack;
    public string food_type;

    // Use this for initialization
    void Start () {

        keepTrack = 0;
        parent = GameObject.Find(this.gameObject.name);
        orders = FindObjectOfType<Orders>();
        setItem();
    }

    // Update is called once per frame
    void Update () {

	}

    public void setItem()
    {
        string item = "blah";
        int randomNum = Random.Range(1, 26);
        if (randomNum <= 8 && randomNum >= 1)
        {
            item = "cupNoodle";
        }

        else if (randomNum <= 15 && randomNum >= 9)
        {
            item = "hotPocket";
        }

        else if (randomNum <= 22 && randomNum >= 16)
        {
            item = "popcorn";
        }

        else if (randomNum <= 26 && randomNum >= 23)
        {
            item = "tvDinner";
        }

        if (item == "cupNoodle")
        {
            food_type = "cupNoodle";
            this.transform.GetChild(0).gameObject.SetActive(true);
            List<int> to_set = new List<int> { 1, 2, 3 };
            set_others_to_false(to_set);
        }
        if (item == "hotPocket")
        {
            food_type = "hotPocket";
            this.transform.GetChild(1).gameObject.SetActive(true);
            List<int> to_set = new List<int> { 0, 2, 3 };
            set_others_to_false(to_set);
        }
        if (item == "popcorn")
        {
            food_type = "popcorn";
            this.transform.GetChild(2).gameObject.SetActive(true);
            List<int> to_set = new List<int> { 0, 1, 3 };
            set_others_to_false(to_set);
        }
        if (item == "tvDinner")
        {
            food_type = "tvDinner";
            this.transform.GetChild(3).gameObject.SetActive(true);
            List<int> to_set = new List<int> { 0, 1, 2 };
            set_others_to_false(to_set);
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
