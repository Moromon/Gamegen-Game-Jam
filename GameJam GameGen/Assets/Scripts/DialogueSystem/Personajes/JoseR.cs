using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DialogueSystem.Personajes
{
    public class JoseR : PersonajePrueba
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
                case "Parranda":
                    joseCatalinaParranda = true;
                    break;
                case "Jose Manuel":
                    apareceJoseManuel = true;
                    break;
                default: break;
            }
        }
    }
}