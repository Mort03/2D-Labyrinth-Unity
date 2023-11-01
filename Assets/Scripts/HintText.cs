using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HintText : MonoBehaviour
{

    public TMP_Text hintText;

    public string hint = "Do not touch the coins for ending 1";

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.H))
        {
            hintText.text = hint.ToString();
        }
    }
}
