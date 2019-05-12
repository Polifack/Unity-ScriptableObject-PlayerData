using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerDamageListener : MonoBehaviour
{
    public Image img;
    public void changeColour()
    {
        img.color = Color.red;
    }
}
