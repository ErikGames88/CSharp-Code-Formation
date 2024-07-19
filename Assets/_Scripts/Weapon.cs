using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Weapon 
{
    /*
    *WATCH OUT!*: "LearningCode" is the class used for this struct to create "weapons"

    * STRUCTS *
    A "struct" (structure) is also a template, like classes, but with differences

    * Features: 
    - It is a type of value: it passes through the value it has, instead of the reference (its values are copied)
    - It is declared with the keyword "struct" and an unique name (Weapon)
    - It can contain variables, constructors and methods
    - Variables and methods are accessed by their unique names
    - Variables cannot be initialised with values within the declaration, unless if they are static or constant:
        - Static variable: shared by the whole structure ("static" modifier)
        - Constant variable: the value does not change. Example: pi number ("const" modifier)
    - Constructors must always have parameters
    - There is a default constructor that automatically sets all variables to default values based on their type

    *** STRUCT SYNTAX: 

    accessModifier struct UniqueName
    {
        Variables
        Constructors
        Methods
    }

    */

    // FIELDS OR PROPERTIES

    // No value is assigned in the declaration.
    public string name; // Weapon name
    public int damage; // Weapon damage

    // CONSTRUCTOR
    public Weapon(string name, int damage) // The constructor necessarily needs parameters
    {
        // Constructor Overloading: Assigning a constructor parameter to a property (variable) of the same name
        this.name = name; // Keyword "This" refers to a property or field of the struct
        this.damage = damage;
    }


    // METHOD
    public void PrintWeaponStatus() // Similar to the one used in the "Character" class
    {
        Debug.LogFormat("The weapon: {0} deals {1} Damage", this.name, this.damage); // Prints the debug logs
    }

}
