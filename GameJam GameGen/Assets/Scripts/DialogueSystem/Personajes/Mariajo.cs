using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DialogueSystem.Personajes
{
    public class Mariajo : PersonajePrueba
    {
        public override void Talk()
        {
            trigger.TriggerDialogue(this);
        }
        public override void Updated(string s)
        {
            switch (s)
            {
                case "Pozo":
                    chaqueta = true;
                    break;
                default: break;
            }
        }
    }
}
