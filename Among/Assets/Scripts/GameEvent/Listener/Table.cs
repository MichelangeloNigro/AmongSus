using UnityEngine;

public class Table : Riutilizzabile.AbstractGameEventListener
{
    [SerializeField] GameObject ReportRable;
    protected override void OnEventRaised()
    {
 
        ReportRable.SetActive(true);
    }
  
}
