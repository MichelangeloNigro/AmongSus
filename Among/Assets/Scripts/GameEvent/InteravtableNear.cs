using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteravtableNear : Riutilizzabile.AbstractGameEventListener
{
    [SerializeField] Button InteractableButton;
    protected override void OnEventRaised()
    {
        InteractableButton.interactable = !InteractableButton.interactable;
    }
}
