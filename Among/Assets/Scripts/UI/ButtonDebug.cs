using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class ButtonDebug : MonoBehaviour
{
    [SerializeField] PlayerCustom data;
    [SerializeField] HatDatabase hatdata;
    [SerializeField] colorDAtabase ColorData;
    [SerializeField] GameObject hat;
    [SerializeField] GameObject color;
    [SerializeField] Riutilizzabile.GameEvent PlayerCustomChanged;
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void changetoimpostor()
    {
        PlayerCustomChanged.Raise();

        data.tipo = PlayerCustom.type.Impostor;
    }
     public void changetonormal()
    {
        PlayerCustomChanged.Raise();

        data.tipo = PlayerCustom.type.Normal;

    }
    public void changehat()
    {
        hat.SetActive(!hat.activeSelf);
    } 
    public void Coloron()
    {
        color.SetActive(!color.activeSelf);
    }
    public void Colorset(int i)
    {
        data.colore = ColorData.colori[i];
        PlayerCustomChanged.Raise();
    }
    public void Hatset(int i)
    {
        data.hat = hatdata.hats[i];
        PlayerCustomChanged.Raise();

    }

}
