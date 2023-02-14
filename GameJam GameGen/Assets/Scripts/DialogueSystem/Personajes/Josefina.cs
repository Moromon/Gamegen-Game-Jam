using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DialogueSystem.Personajes
{
    public class Josefina : PersonajePrueba
    {
        public override void Talk()
        {
            pedroLlamo = true;
            trigger.TriggerDialogue(this);

        }
        public override void Updated(string s)
        {
            switch (s)
            {
                case "Crucifijo":
                    crucifijoInvestigado = true;
                    break;
                case "Cuchillo":
                    missingCuchillo = true;
                    break;
                default: break;
            }
        }
    }
}
