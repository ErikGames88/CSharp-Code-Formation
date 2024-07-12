using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
***INHERITANCE***
- Original class: "Base Class" or "Parent Class". Inherited class: "Derived Class" or "Child Class"
- Class that inherits from another class 
- It shares its properties or fields and methods
- It can define its own data, that only depends on the inherited class 
- Base class members marked with access modifiers "public", "protected" or "internal", are part of the derived class
- Constructors are not part of the derived class due to they are class-specific. Except when using "base()"
- CLASS HIERARCHY: members, fields and methods flow down from the base class to the derived classes
- It allows not to repeat code in several classes (DRV)
*/
public class Warrior : Character // This "Warrior" class is inherited by the "Character" classs
// Base or Parent class: "Character". Derived or Child class: "Warrior"
{
    /* 
    *COMPOSITION*
    Derived classes can be composed with other classes to make stronger structures (structs)
    */
    public Weapon weapon; // Variable for the warrior to access the weapon. Used in the struct "Weapon"

    public Warrior() : base() // "Warrior" constructor, which calls the default "Character" class constructor 
    {

    }

    public Warrior (string name, Weapon weapon) : base(name) // Call the parent constructor parameter
    {                            // Unique weapon for the "Warrior", not for the "Character"
        // It would be the same:
        // this.name = name;    

        this.weapon = weapon; // Default value for weapon
    }

    /*
    *POLYMORPHISM*
    - Derived classes (such as "Warrior") are treated in the same way as the base class (such as "Character")
    - Allows derived classes to retain the same structure as base classes
    - At the same time, specific requirements can be applied to derived classes
    - "virtual" keyword: Indicates that the statements of the base classes can be modified by the derived classes
    - "override" keyword: Required to modify the statements
    * It is applied to the "PrintStatsInfo" method of the "Character" class
    */

    // This parent method can be modified from here
    public override void PrintStatsInfo() // Same return value, method and parameters
    {      // override keyword to make the changes

        // base.PrintStatsInfo(); // keyword "base" to execute the same method of the base class (Character)

        // Polymorphism: This method now has several forms depending on who is the object calling it 
        Debug.LogFormat("The Scottish warrior {0} fought with his {1} against England", name, weapon.name);
        // Only "Warrior" calls this method here, it is an overwritten version of the father's
        
        // Each ("Character" and "Warrior") has their own version of this method
    }

}
