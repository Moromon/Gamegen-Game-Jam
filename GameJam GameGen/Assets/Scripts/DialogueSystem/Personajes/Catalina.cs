using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DialogueSystem.Personajes
{
    public class Catalina : PersonajePrueba
    {
        public override void Talk()
        {
            horaMimirEstandar = true;
            trigger.TriggerDialogue(this);

        }
        public override void Updated(string s)
        {
            switch (s)
            {
                case "Jose Manuel":
                    apareceJoseManuel = true;
                    break;
                case "Parranda":
                    joseCatalinaParranda = true;
                    break;
                default: break;
            }
        }
    }
}