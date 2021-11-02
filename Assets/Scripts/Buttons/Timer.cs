using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI tiempoText;
    public float tiempo = 0.0f;

    // Update is called once per frame
    void Update()
    {
        tiempo += Time.deltaTime;
        tiempoText.text = "" + tiempo.ToString("f2");
    }
}
