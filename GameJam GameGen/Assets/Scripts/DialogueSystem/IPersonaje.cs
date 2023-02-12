using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPersonaje
{
    bool PistolaInvestigada { get; set; }
    public void Talk();
    public void Updated(string s);
}
