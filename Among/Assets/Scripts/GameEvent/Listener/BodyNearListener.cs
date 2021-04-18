using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BodyNearListener : Riutilizzabile.AbstractGameEventListener
{
    [SerializeField] Button ReportButton;
    protected override void OnEventRaised()
    {
        ReportButton.interactable = !ReportButton.interactable;
    }
}
