using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public static int points = 0;
    public Text pointText;

    // Start is called before the first frame update
    void Start()
    {
        pointText.text = "Enemies defeated: " + points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = $"Enemies defeated: {points}";
    }
}
