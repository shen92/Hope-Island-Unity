﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerSlider : MonoBehaviour
{

    public GameObject healthSlider;

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.GetComponent<Slider>().value = 1;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
