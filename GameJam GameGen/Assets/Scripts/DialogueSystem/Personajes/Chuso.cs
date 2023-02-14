using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DialogueSystem.Personajes
{
    public class Chuso : PersonajePrueba
    {
        public override void Talk()
        {

            identificacion = true;
            horaMimirEstandar = true;
            trigger.TriggerDialogue(this);

        }
        public override void Updated(string s)
        {
            switch (s)
            {
                case "Sotano":
                    chusoSotano = true;
                    break;
                default: break;
            }
        }
    }
}
