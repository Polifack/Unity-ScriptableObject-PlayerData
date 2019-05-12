using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "Player")]
public class Player : ScriptableObject
{
    public int maxHP;
    public int currentHP;
    public int maxMana;
    public int currentMana;

    private List<PlayerEventListener> listeners = 
        new List<PlayerEventListener>();

    public void RaiseEvent()
    {
        foreach (PlayerEventListener listener in listeners)
        {
            listener.OnEventRaised();
        }
    }

    public void RegisterListener(PlayerEventListener PEL)
    {
        listeners.Add(PEL);
    }
    public void UnregisterListener(PlayerEventListener PEL)
    {
        listeners.Remove(PEL);
    }
}
