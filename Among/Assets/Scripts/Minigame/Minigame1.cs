using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame1 : Riutilizzabile.Singleton<Minigame1>, Iminigame
{
    [SerializeField] Riutilizzabile.GameEvent Complete;
    public void execute()
    {
        if(Manager.Instance.TaskCompleted!= Manager.Instance.TotalTask)
        Manager.Instance.TaskCompleted++;
        finish();
    }

    public void finish()
    {
        Complete.Raise();
        Destroy(gameObject);
    }

    public void restart()
    {
        Destroy(gameObject);
        Instantiate(Manager.Instance.currentminigame);
    }
}
