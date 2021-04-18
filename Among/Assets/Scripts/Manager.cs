using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Manager : Riutilizzabile.Singleton<Manager>
{
    public int TaskCompleted;
    public GameObject currentminigame;
    public GameObject currentBody;
    public GameObject LocalPlayer;
    public GameObject good;
    public GameObject impostor;
    public float TimeForTable;
    private void Start()
    {
        if (LocalPlayer.GetComponent<Movement>().data.tipo == PlayerCustom.type.Normal)
        {
            good.SetActive( true);
        }
        if (LocalPlayer.GetComponent<Movement>().data.tipo == PlayerCustom.type.Impostor)
        {
            impostor.SetActive(true);
        }
    }
    IEnumerator Timer()
    {

    }
}