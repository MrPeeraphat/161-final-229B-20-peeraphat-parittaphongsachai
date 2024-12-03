using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public string Name = "Dog";
    private float dailyFoodConsumtion = 0.5f;
   
    private int activityLevel = 3;

    public override float CalculateFoodRequirement()
    {
        Debug.Log($"{Name} eats {dailyFoodConsumtion} kg of food daily with activity level {activityLevel}");
        float dogRequirement;
        dogRequirement = dailyFoodConsumtion * activityLevel * 7;
        return dogRequirement;
    }

    public override void MakeSound()
    {
        Debug.Log($"{Name} barks: Woof Woof!");
    }
}
