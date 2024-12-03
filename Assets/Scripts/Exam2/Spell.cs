using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    public virtual void Cast()
    {
        Debug.Log("Spell-Casting Simulation Started!");
        Debug.Log("Casting a genetic spell");
    }
    public void Cast(string spellNameCast)
    {
        string enemyName = "Slime";      
        Debug.Log($"Casting a spell on target {enemyName}");
    }
    public void Cast(string enemyName, int spellPower)
    {       
        Debug.Log($"Casting a spell on {enemyName}! With power level: {spellPower}");
    }
}
