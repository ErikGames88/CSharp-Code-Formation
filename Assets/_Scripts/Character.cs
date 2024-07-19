using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    /*
    *WATCH OUT!*: "LearningCode" is the other class used for this template to create "characters"
    
    *** CLASS SYNTAX: 

    accessModifier class UniqueName
    {
        Variables
        Constructors
        Methods
    }

    * It is declared with the keyword "class" and an unique name (Character)
    * Empty class not inherited from MonoBehaviour
    * Character is registered as a public class
    * It is a public template (a blueprint) that any other class can use to create characters
    * INSTANTIATE: Create an object from a specific set of instructions
       - Create a copy of this class (Remember: In LearningCode)
    * INSTANCE: The object that is created from the template (from this Character class to the LearningCode class)
       - The instance follows the instructions of the template
       - Each new instance of "Character" is an object that can be used in code
       - Use the reserved word "new" to create a new instance
       - The Character class is public: an instance of it can be created in any other class (LearningCode) 
    */

    // FIELDS OR PROPERTIES (Variables within the concept of Class)

    public string name; // Variable without value. Each character will have a different name
    public int experience = 0; // Variable with a default value. All characters start with 0 experience 

    /*
    * CONSTRUCTORS *

    - Special methods that are automatically enabled when the class instance is created
    - Build the class according to the template specified in the class
    - If no constructor is specified, a base is created and sets variables to their default values (0, false, null)
    - They are defined with input parameters and are used to set the values of class variables: 
        -Initialisation process-
    - The same class can have several constructors

    * Constructor Syntax:
       - It must be public
       - No return value (not specified)
       - The name must always be exactly the same as the class name
    */

    // Basic constructor without input parameters
    public Character()
    {
        name = "Unknown"; // Default value assigned
    }

    // Constructor with input parameter
    public Character(string name) // String as input parameter (name)
    {
        // Constructor Overloading: Assigning a constructor parameter to a property (variable) of the same name
        this.name = name; // Keyword "This" refers to a property or field of the class 
        // This: Indicates that it is a variable class, not an input parameter
    }

    /*
    METHODS 
      -DRY (Don't repeat yourself): Avoid repetition of code and encapsulate it in methods
      -Abstraction of functionality: Do it towards a method or function
    */
    // *Use of Polymorphism*
    public virtual void PrintStatsInfo() // Used to compress code and make it easier to read
    {      // virtual keyword, so that "Warrior" (child) can modify statements of this class (parent)

        Debug.LogFormat("Character: {0} - {1} EXP", this.name, this.experience); // Prints the debug logs

        // Each ("Character" and "Warrior") has their own version of this method 
    }

    
    // *ENCAPSULATION*
    // Defines the level of accessibility of an object's variables and methods from the external code
    private void Reset() // Not accessible from other classes due to its level of protection (private) 
    {
        this.name = "Unknown"; // Resets default values. 
        this.experience = 0;
    } 
}




