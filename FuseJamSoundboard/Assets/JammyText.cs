using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Outline))]
public class JammyText : MonoBehaviour {

    private Outline outline;
    public int xMult = 25;
    public int yMult = 50;

    private void Start()
    {
        outline = GetComponent<Outline>();
    }

    private void Update()
    {
        float a = Mathf.Sin(Time.time);
        float b = Mathf.Cos(Time.time);
        outline.effectDistance = new Vector2(a * xMult, b * yMult);
    }
}
