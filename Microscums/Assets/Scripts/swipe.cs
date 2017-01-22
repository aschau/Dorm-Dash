using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class swipe : MonoBehaviour
{
    public bool held, timer = false;
    private int counter = 0;
    Vector3 originalPosition;
    GameObject score, timerIcon, timeIcon;
    void Awake()
    {
        score = GameObject.Find("microwaveControl");
        timerIcon = GameObject.Find("Timer");
        timeIcon = GameObject.Find("Time");
    }
    // Use this for initialization
    void Start()
    {
        timerIcon.SetActive(false);
        timeIcon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer == true)
        {
            counter += 1;
        }
        if (counter >= 15)
        {
            timerIcon.SetActive(false);
            timeIcon.SetActive(false);
            counter = 0;
            timer = false;
        }

    }

    public void onPointerDown()
    {
        held = true;
        originalPosition = Input.mousePosition;
    }

    public void onPointerUp()
    {
        if (held == true)
        {
            if ((originalPosition.x) < Input.mousePosition.x)
            {
                held = false;
                score.GetComponent<microControl>().swipes += 1;
                timerIcon.SetActive(true);
                timeIcon.SetActive(true);
                timeIcon.GetComponent<Text>().text = score.GetComponent<microControl>().swipes.ToString();
                timer = true;
            }
            else
            {
                held = false;
            }
        }
    }
}
