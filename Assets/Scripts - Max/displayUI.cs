﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayUI : MonoBehaviour
{

    public string myString;
    public Text myText;
    public float fadeTime;
    public bool displayInfo;

    // Use this for initialization
    void Start()
    {
        myText = GameObject.Find("SkyTower").GetComponent<Text>();
        //myText.color = Color.clear;
        myText = GameObject.Find("HarbourBridge").GetComponent<Text>();
        //myText.color = Color.clear;
        //Screen.showCursor = false;
        //Screen.lockCursor = true;
    }

    void Update()
    {
        FadeText();

        /*if (Input.GetKeyDown (KeyCode.Escape))
        {
            Screen.lockCursor = false;
        } */
    }
    
    void OnMouseOver()
    {
        displayInfo = true;
    }

    void OnMouseExit()
    {
        displayInfo = false;
    }

    void FadeText()
    {

        if (displayInfo)
        {
            myText.text = myString;
            myText.color = Color.Lerp(myText.color, Color.black, fadeTime * Time.deltaTime);
        }
        else
        {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }
}
        