using UnityEngine;
using UnityEngine.UI;

public class NeutralButton : MonoBehaviour
{
    [SerializeField] Riutilizzabile.GameEvent Report;
    [SerializeField] Riutilizzabile.GameEvent Report_Table;
    [SerializeField] Button reportButton;
    public void SetState(GameObject gameObject)
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
    public void exit(GameObject gameObject)
    {
        Destroy(gameObject);
    }
    public void report()
    {
        if (Manager.Instance.currentBody != null)
        {
            if (reportButton.interactable == true)
                reportButton.interactable = false;
            Report.Raise();
            Destroy(Manager.Instance.currentBody);
        }
        else
        {
            Report_Table.Raise();
        }
    }
    public void relaseCorutine()
    {
        Manager.Instance.curr_corutine = null;
    }
}
