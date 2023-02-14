using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DialogueSystem.Personajes
{
    public class Drislav : PersonajePrueba
    {
        public override void Talk()
        {
            trigger.TriggerDialogue(this);
        }
        public override void Updated(string s)
        {
            switch (s)
            {
                case "Croata":
                    horaMimirJoseManuel = true;
                    break;
                default: break;
            }
        }
    }
}
