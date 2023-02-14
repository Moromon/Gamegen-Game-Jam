using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DialogueSystem.Personajes
{
    public class Ana : PersonajePrueba
    {
        public override void Talk()
        {
            horaMimirAna = true;
            identificacion = true;
            trigger.TriggerDialogue(this);

        }
        public override void Updated(string s)
        {
            switch (s)
            {
                case "Miguel":
                    anaMiguel = true;
                        break;
                case "Chaqueta":
                    chaqueta = true;
                    break;
                default: break;
            }
        }
    }
}
