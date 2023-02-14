using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DialogueSystem.Personajes
{
    public class MiguelAngel : PersonajePrueba
    {
        public override void Talk()
        {
            nudillosMiguelAInvestigados = true;
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
