using System.Collections;
using UnityEngine;

namespace Assets.Scripts.DialogueSystem.Personajes
{
    public class Timoteo : PersonajePrueba
    {
        public override void Talk()
        {
            identificacion = true;
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