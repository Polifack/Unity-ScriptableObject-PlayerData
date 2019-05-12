using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerEventListener : MonoBehaviour
{
    public Player Player;
    public UnityEvent Response;
    public void OnEventRaised()
    {
        Response.Invoke();
    }
    public void OnEnable()
    {
        Player.RegisterListener(this);
    }
    public void OnDisable()
    {
        Player.UnregisterListener(this);
    }
}
