using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MsgNPC : MonoBehaviour
{

    int index = 0;
    public string[] msg = {
        "Hola, ¿quieres hablar con migo?", //0
        "Es un gusto conocetre",           //1
        "Hasta promto"                     //2
    };

    public string GetMsg()
    {
        return msg[index];
    }

    public void BtOK()
    {
        index = 1;
    }

    public void BtCancel()
    {
        index = 2;
    }

    public void Reiniciar()
    {
        index = 0;
    }

}
