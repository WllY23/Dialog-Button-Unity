using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Detectar : MonoBehaviour
{
    [SerializeField] GameObject msgPanel;
    [SerializeField] Text msgText;
    [SerializeField] Button btnOK;
    [SerializeField] Button btnCancel;

    GameObject actualNPC;

    void Start()
    {
        GetComponent<Collider>().isTrigger = true;
        msgPanel.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "npc")
        {
            actualNPC = other.gameObject;
            string msg = actualNPC.GetComponent<MsgNPC>().GetMsg();
            msgText.text = msg;
            msgPanel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "npc")
        {
            //Debug.Log("Hit npc");
            if (actualNPC)
            {
                actualNPC.GetComponent<MsgNPC>().Reiniciar();
                string msg = actualNPC.GetComponent<MsgNPC>().GetMsg();
                msgText.text = msg;
            }
            msgPanel.SetActive(false);
        }
    }

    public void BtOK()
    {
        if (actualNPC)
        {
            actualNPC.GetComponent<MsgNPC>().BtOK();
            string msg = actualNPC.GetComponent<MsgNPC>().GetMsg();
            msgText.text = msg;
        }
    }

    public void BtCancel()
    {
        if (actualNPC)
        {
            actualNPC.GetComponent<MsgNPC>().BtCancel();
            string msg = actualNPC.GetComponent<MsgNPC>().GetMsg();
            msgText.text = msg;
        }
    }

}
