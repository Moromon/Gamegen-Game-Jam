using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perico : PersonajePrueba
{
    public override void Talk()
    {
       
        trigger.TriggerDialogue(this);

    }
    public override void Updated(string s)
    {
        switch (s)
        {
            case "Pistola":
                pistolaInvestigada = true;
                break;
            case "wherePistola":
                wherePistola = true;
                break;
            case "Moraton":
                moratonJuanInvestigado = true;
                break;
            default: break;
        }
    }
}
