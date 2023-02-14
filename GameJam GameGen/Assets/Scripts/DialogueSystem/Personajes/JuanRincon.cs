using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DialogueSystem.Personajes
{
    public class JuanRincon : PersonajePrueba
    {
        public override void Talk()
        {
            horaMimirEstandar = true;
            moratonJuanInvestigado = true;
            chaqueta = true;

            trigger.TriggerDialogue(this);

        }
        public override void Updated(string s)
        {
            switch (s)
            {
                default: break;
            }
        }
    }
}
