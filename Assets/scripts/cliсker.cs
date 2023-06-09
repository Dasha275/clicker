using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cliсker : MonoBehaviour
{
    public int count;
    public Text text;
    public string nameBuy;
    public GameObject butStore, panelbox;
    public Camera myCamera;

    public void Start()
    {
        panelbox.SetActive(false);
    }

    public void Click()
    {
        count++;
        text.text = count.ToString();
    }

    public void openStore()
    {
        panelbox.SetActive(true);
    }

    public void closeStore()
    {
        panelbox.SetActive(false);
    }

    public void buyStore()
    {
        if (nameBuy == "pink" && count >= 100)
        {
            myCamera.GetComponent<Camera>().backgroundColor = Color.magenta;
            count -= 100;
        }
        if (nameBuy == "white" && count >= 100)
        {
            myCamera.GetComponent<Camera>().backgroundColor = Color.white;
            count -= 100;
        }
        text.text = count.ToString();
    }

    public void buyStoreBGpink()
    {
        nameBuy = "pink";
        buyStore();
    }

    public void buyStoreBGwhite()
    {
        nameBuy = "white";
        buyStore();
    }
}

