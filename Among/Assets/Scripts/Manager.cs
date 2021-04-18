using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Manager : Riutilizzabile.Singleton<Manager>
{
    [HideInInspector] public float TaskCompleted;
    [HideInInspector] public float TotalTask;
    public GameObject currentminigame;
    public GameObject currentBody;
    public GameObject LocalPlayer;
    public GameObject good;
    public GameObject impostor;
    public float TimeForTable;
    public float TimeForvotatione;
    [SerializeField] Button table;
    public Riutilizzabile.GameEvent timerTable;
    public Coroutine curr_corutine;
    private void Start()
    {
        if (LocalPlayer.GetComponent<Movement>().data.tipo == PlayerCustom.type.Normal)
        {
            good.SetActive(true);
        }
        if (LocalPlayer.GetComponent<Movement>().data.tipo == PlayerCustom.type.Impostor)
        {
            impostor.SetActive(true);
        }
        timerTable.Raise();
        TotalTask = LocalPlayer.GetComponent<Movement>().data.TaskPerInstance;
    }
    public IEnumerator Timer()
    {
        table.interactable = false;
        yield return new WaitForSeconds(TimeForTable);
        table.interactable = true;

    }
}