using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskCompleted : Riutilizzabile.AbstractGameEventListener
{
    [SerializeField] Slider slider;
    protected override void OnEventRaised()
    {
        if (Manager.Instance.TaskCompleted <= Manager.Instance.TotalTask)
            slider.value = Manager.Instance.TaskCompleted/ Manager.Instance.TotalTask;
        if (Manager.Instance.TaskCompleted == Manager.Instance.TotalTask)
        {
            Application.Quit();
        }
    }
}
