using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DialogueSystem.Personajes
{
    public class Gonzalo : PersonajePrueba
    {
        public override void Talk()
        {
            horaMimirJoseManuel = true;
            trigger.TriggerDialogue(this);

        }
        public override void Updated(string s)
        {
            switch (s)
            {
                case "Jose Manuel":
                    apareceJoseManuel = true;
                    break;
                default: break;
            }
        }
    }
}