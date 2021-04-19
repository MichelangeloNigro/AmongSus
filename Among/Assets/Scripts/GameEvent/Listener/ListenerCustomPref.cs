using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenerCustomPref : Riutilizzabile.AbstractGameEventListener
{
    protected override void OnEventRaised()
    {
        Manager.Instance.setPreferences();
    }
}
