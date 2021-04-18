using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigame1 : Riutilizzabile.Singleton<Minigame1>, Iminigame
{
    public void execute()
    {
        Manager.Instance.TaskCompleted++;
        finish();
    }

    public void finish()
    {
        Destroy(gameObject);
    }

    public void restart()
    {
        throw new System.NotImplementedException();
    }
}
