using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpeel : Spell
{
    public void Cast(string spellName)
    {
        spellName = "Ice Shard";
        Debug.Log($"Casting a {spellName} spell! Freeze the enemy!");
    }
}
