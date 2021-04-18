using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListenerVents : Riutilizzabile.AbstractGameEventListener
{
    [SerializeField] GameObject VentButton;
    [SerializeField] GameObject SabotageButton;
    protected override void OnEventRaised()
    {
        VentButton.SetActive(!VentButton.activeSelf);
        SabotageButton.SetActive(!SabotageButton.activeSelf);
    }
}
