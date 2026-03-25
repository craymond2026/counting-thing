using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int scoreMultiplier;
    public Text CounterText;
    private static int Count = 0;

    private void Start()
    {
        Count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        Count += 1 * scoreMultiplier;
        CounterText.text = "Count : " + Count;
        Destroy(other.gameObject);
    }
}
