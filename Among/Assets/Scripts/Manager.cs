using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Manager : Riutilizzabile.Singleton<Manager>
{
    [HideInInspector] public float TaskCompleted;
    [HideInInspector] public float TotalTask;
    public float TotalNormalPlayer;
    [HideInInspector] public GameObject currentminigame;
    [HideInInspector] public GameObject currentBody;
    [HideInInspector] public GameObject currentTarget;
    public GameObject LocalPlayer;
    public GameObject good;
    public GameObject goodTrigger;
    public GameObject impostor;
    public GameObject impostorTrigger;
    public float TimeForTable;
    public float TimeForvotatione;
    [SerializeField] Button table;
    public Riutilizzabile.GameEvent timerTable;
    public Coroutine curr_corutine;
    public PlayerCustom dataLocalPlayer;
    public SpriteRenderer PlayerSprite;
    public SpriteRenderer Hat;
    private void Start()
    {
        setPreferences();
        timerTable.Raise();
        TotalTask = dataLocalPlayer.TaskPerInstance;
    }
    public IEnumerator Timer()
    {
        table.interactable = false;
        yield return new WaitForSeconds(TimeForTable);
        table.interactable = true;

    }
    public void setPreferences()
    {
        if (dataLocalPlayer.tipo == PlayerCustom.type.Normal)
        {
            good.SetActive(true);
            goodTrigger.SetActive(true);
            impostor.SetActive(false);
            impostorTrigger.SetActive(false);
        }
        if (dataLocalPlayer.tipo == PlayerCustom.type.Impostor)
        {
            impostor.SetActive(true);
            impostorTrigger.SetActive(true);
            good.SetActive(false);
            goodTrigger.SetActive(false);
        }
        PlayerSprite.color = dataLocalPlayer.colore;
        Hat.sprite = dataLocalPlayer.hat;
    }
}