using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightLerp : MonoBehaviour
{
    public float smooth = 2f;
    private Color newColor;
    private Color colorA = Color.magenta;
    private Color colorB = Color.yellow;

    void Awake()
    {
        GetComponent<Light>().color = newColor;
    }
    

    // Update is called once per frame
    void Update()
    {
        ColorChanging();
    }

    void ColorChanging()
    {
       

        if (Input.GetKeyDown(KeyCode.Z))
        {
            newColor = colorA;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            newColor = colorB;
        }

        GetComponent<Light>().color = Color.Lerp(GetComponent<Light>().color, newColor, Time.deltaTime * smooth);
    }
}
