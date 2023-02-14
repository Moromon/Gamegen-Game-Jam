using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DialogueSystem.Personajes
{
    public class MiguelR : PersonajePrueba
    {
        public override void Talk()
        {
            pistolaInvestigada = true;
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
                case "Soga":
                    sogaInvestigada = true;
                    break;
                default: break;
            }
        }
    }
}