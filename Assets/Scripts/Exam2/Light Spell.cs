using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSpell : Spell
{
    public void Cast(string spellName)
    {
        spellName = "Blitzing";
        Debug.Log($"Casting a {spellName} spell! Slash enemy at once!");
    }
}
