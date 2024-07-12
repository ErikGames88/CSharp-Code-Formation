using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCode : MonoBehaviour
{
    // *WATCH OUT!*: This class is used for instances of the "Character Class" and the "Weapon Struct"
    
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

        // Using the "struct" Weapon
        Weapon hauntingBow = new Weapon("Haunting Bow", 150); // Assigning values to constructor parameters
        hauntingBow.PrintWeaponStatus(); // Using the struct method to display values

        /* 
        * Type of data by REFERENCE *
        
        - A CLASS such as "Character" is a reference type
        - Variables do not contain the information of their class
        - Contain a reference or location of the object in the program memory
        - If there are several variables linking the same reference, a change in one of them affects all the others
        */

        Character hero2 = hero; // "hero2" is assigned a reference, not data (from "hero")
        hero.PrintStatsInfo(); 
        hero2.PrintStatsInfo(); // Both "hero" and "hero2" display the same: "Character: Unknown - 0 EXP" 
        // "hero" is reserved in a memory location, "hero2" points to the same memory location
        // Both "hero" and "hero2" point to the same memory location: new Character();

        hero2.name = "Sonic"; // Change of value to "hero2" (for "Unknown" to "Sonic")
        hero.PrintStatsInfo(); // It displays "Character: Sonic"
        hero2.PrintStatsInfo(); // It also displays "Character: Sonic"
        /* Only one value has changed (hero2), but now both (hero and hero2) have the same value (Sonic):
           - Reference types are not copied when assigned to new variables
           - Any change to a reference affects all other variables
           - If the value of "hero" is changed, it will also be moved to "hero2"
        */

        /* 
        * Type of data by VALUE *
        
        - A STRUCT such as "Weapon" is a value type
        - Data is stored in the variable without any reference or connection to its location in memory
        - Useful for creating objects that need to be copied quickly and efficiently
        - It keeps their identities separate
        */

        Weapon warBow = hauntingBow; // New variable by copying the previous one
        // Continue displaying the same values:
        hauntingBow.PrintWeaponStatus(); // "The weapon Haunting Bow deals 150 damage"
        warBow.PrintWeaponStatus(); // "The weapon Haunting Bow deals 150 damage"

        // Changes to the new warBow variable:
        warBow.name = "War Bow"; // New name
        warBow.damage = 200; // New damage
        // Displays the changes made previously:
        hauntingBow.PrintWeaponStatus(); // Retains the first given values ("Hunting Bow, 150")
        warBow.PrintWeaponStatus(); // Updates the new modified values ("The weapon War Bow deals 200 damage")
        
        /* 
        * IN SHORT: *
          - Classes retain references to an object and a change is perpetuated in all references
          - Structures are copied and modified with their objects separated
        */

        Weapon greatSword = new Weapon("Great Sword", 500); // Example variable to use in "Warrior" instance

        // Character Constructor -> Warrior Contructor -> Use it in here
        Warrior scottishWarrior = new Warrior("William Wallace", greatSword); // Invoking the "Warrior" Constructor
        // The variable scottishWarrior is also a "Character"
        // *USE OF THE COMPOSITION: The variable greatSowrd as parameter from the "Warrior" constructor
         
        scottishWarrior.PrintStatsInfo(); // "Character: William Wallace - 0 EXP"


    }

   
}
