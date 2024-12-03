using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    public string Name = "Bird";
    private float dailyFoodConsumtion = 0.1f;

    private float weight;

    public override float CalculateFoodRequirement()
    {
        Debug.Log($"{Name} eats {dailyFoodConsumtion} kg of food daily and weights {weight}");
        return weight;
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} chirps: Tweet Tweet!");
    }



}
