using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinTextEnd1 : MonoBehaviour
{
    public TMP_Text winText_1;
    public GameObject Object_1;
    public int goal_1;

    public string win_1 = "YOU WON IN ENDING 1!";

    public void Goal1()
    {
        goal_1++;
    }

    public void FixedUpdate()
    {
        if (goal_1 == 1)
        {
            winText_1.text = win_1.ToString();
        }
    }
}
