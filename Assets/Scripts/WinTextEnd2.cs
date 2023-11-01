using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinTextEnd2 : MonoBehaviour
{
    public TMP_Text winText_2;
    public GameObject Object_2;
    public int goal_2;

    public string win_2 = "YOU WON IN ENDING 2!";

    public void Goal2()
    {
        goal_2++;
    }

    public void FixedUpdate()
    {
        if (goal_2 == 1)
        {
            winText_2.text = win_2.ToString();
        }
    }
}
