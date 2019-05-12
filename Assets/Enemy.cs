using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Damage;
    public Player player;
    
    public void doDamage()
    {
        player.RaiseEvent();
        if (player.currentHP - Damage > 0)
            player.currentHP = player.currentHP - Damage;
        else
            player.currentHP = 0;
    }
}
