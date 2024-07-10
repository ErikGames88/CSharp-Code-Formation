using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCode : MonoBehaviour
{
    // WATCH OUT!: This class is used for instances of the "Character" class
    
    void Start()
    {
        /*
        * Instantiate a new character from the Character class
          - Data type: "Character". It is now a variable, an instance of the "Character" class
          - Variable unique name: "hero" 
          - Key Word: "new"
          - Calling the "Character" class again 
        
        - As it is an instance of "Character", there are no default values (0 or null)
        - Set the value of a variable if it is to be applied to all instances
        */
        
        Character hero = new Character(); // Basic constructor (no parameters)
        // It is the instance that is created from the template ("Character" class)

        // Accessing "Character" class variables using dot syntax (hero.name, hero.experience)
        // Debug.LogFormat("Character: {0} - {1} EXP", hero.name, hero.experience); // Hero: Unknown - 0 EXP
        hero.PrintStatsInfo(); // DRY (using a method)

        Character heroine = new Character("Lara Croft"); // Second constructor that takes the string parameter
        // Second instance (heroine) using the constructor with a "name" parameter

        // Debug.LogFormat("Heroine: {0} - {1} EXP", heroine.name, heroine.experience); 
        heroine.PrintStatsInfo(); //DRY (using a method again)

    }

    
    void Update()
    {
        
    }
}
