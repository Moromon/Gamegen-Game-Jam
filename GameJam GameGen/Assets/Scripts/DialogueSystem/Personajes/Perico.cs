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
            case "pistola":
                pistolaInvestigada = true;
                break;
            default: break;
        }
    }
}
