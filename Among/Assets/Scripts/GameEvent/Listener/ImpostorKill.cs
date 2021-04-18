using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImpostorKill : Riutilizzabile.AbstractGameEventListener
{
    [SerializeField] Button killB;
    protected override void OnEventRaised()
    {
        killB.interactable = !killB.interactable;
    }
}
