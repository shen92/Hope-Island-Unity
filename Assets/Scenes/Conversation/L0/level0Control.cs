﻿using UnityEngine;

public class level0Control : MonoBehaviour
{
    [SerializeField] private GameObject[] panels;
    [SerializeField] private GameObject[] dialogs;
    private int curIndex = 0;

    public void ClickEvent1()
    {
        curIndex++;
        if (curIndex < 8)
        {
            dialogs[curIndex - 1].SetActive(false);
            dialogs[curIndex].SetActive(true);
        } else
        {
            panels[0].SetActive(false);
            panels[1].SetActive(true);
        }
    }
    public void ClickEvent2()
    {
        curIndex++;
        if (curIndex < 7)
        {
            dialogs[curIndex - 1].SetActive(false);
            dialogs[curIndex].SetActive(true);
        }
    }


    
}
