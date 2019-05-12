using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    public int Power;
    public Player player;

    public void doHealing()
    {
        player.RaiseEvent();
        if (player.currentHP + Power < player.maxHP)
            player.currentHP = player.currentHP + Power;
        else
            player.currentHP = player.maxHP;
            
    }
}
