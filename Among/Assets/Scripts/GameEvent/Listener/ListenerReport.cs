using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenerReport : Riutilizzabile.AbstractGameEventListener
{
    [SerializeField] GameObject votationUI;
    protected override void OnEventRaised()
    {
        votationUI.SetActive(true);
    }
}
