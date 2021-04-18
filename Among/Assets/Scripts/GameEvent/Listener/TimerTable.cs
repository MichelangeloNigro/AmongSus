public class TimerTable : Riutilizzabile.AbstractGameEventListener
{
    protected override void OnEventRaised()
    {

        if (Manager.Instance.curr_corutine == null)
            Manager.Instance.curr_corutine = StartCoroutine(Manager.Instance.Timer());
    }
}
