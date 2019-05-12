using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour
{
    public Text text;
    public Player player;

    private void Start()
    {
        text.text = "PLAYER HP: " + player.maxHP + "/" + player.currentHP;
    }

    private void FixedUpdate()
    {
        text.text = "PLAYER HP: " + player.maxHP + "/" + player.currentHP;
    }
}
