﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScripts : MonoBehaviour
{

    public GameObject healthSlider;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        healthSlider.GetComponent<Slider>().value = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerP = Camera.main.WorldToScreenPoint(player.transform.position);
        healthSlider.GetComponent<RectTransform>().position = playerP + Vector2.up * 85;

    }
}
