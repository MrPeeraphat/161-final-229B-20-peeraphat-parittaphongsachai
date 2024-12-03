using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    public void Cast(string spellName)
    {
        spellName = "Fireball";
        Debug.Log($"Casting a {spellName} spell! Burn them all!");
    }
}
