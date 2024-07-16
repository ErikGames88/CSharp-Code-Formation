using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class VariablesAndMethods : MonoBehaviour
{
    //*COMMENTS*
    // Three types: // or /**/ and /// 
    // This is an only one line remark
    /* This is an
     over one
     line remark */
    /// This is a method summary

    
    /* CLASSES. Sintax:
    
    accessModifier class UniqueName : Possible Inheritance (like MonoBehaviour)
    {
        Variables
        Methods   
        Constructors
    }
    
    */
    
    /* VARIABLES:
     * Access Modifier (public / private / protected / internal)
     * Data type (byte /int / float / double / string / bool / other)
     * Variable name
     * Set default value (Optional)
     * Semicolon */
    
    // Example: accessModifier dataType uniqueName = value;
    
    
    public int currentAge = 35;
    private int addedAge; // Default value = 0

    public float pi = 3.14f; // Default value = 0.0f
    public string firstName = "Erik"; // Default value = null
    public bool isStudying = true; // Default value = false

    // *Placeholders: Temporary value used to indicate that an actual value is expected at that location
    
    // CASTINGS AND CONVERSIONS 
    private float implicitConversion = 5; // Implicit Casting: 5.0f (Int number is made as a float)
    private int explicitConversion = (int) 3.14; // Explicit Casting (dataType): 3 (loses part of its value)
    private string test = 150.ToString(); // "150" Method ToString (Number like a string)
    
    
    // Variables are always in Camel Case (lowercase + uppercase)
    private int maxHealth = 100; // Example
    private bool isEnemyAwake; // Descriptive names
    
    // SCOPE OF VISIBILITY: Class scope
    private string characterName = "Finn"; // Usable in whole class (LearningCode)
    // Check CreateCharacter method to Local level
    
    /* ARITHMETIC (BEDMAS) Bracket, Exponent, Division, Multiplication, Addition, Subtraction
     / Division
     * Multiplication
     + Addition (sum)
     - Subtraction
     % Remainder (of a division)  */
    
    // 5+4-3/2*1 = 8
    // 5+(4-3)/2*1 = 5  (Logical order of operations: First what's inside the brackets)

    
    void Arithmetic()
    {
        //Assignment operator: =
        //Assignments with operations : /= , *= , += , -=
        int currentValue = 2;
        // currentValue = currentValue * 2; --> Explicit assignment (72) Overwrite the value
        currentValue *= 2; // Implicit assignment (72) -Usually used-
        
        // String addition (Concatenation):
        string fullName = "Erik " + "Pan";
        Debug.Log(fullName);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        var newAge = 5; // Infers the variable type by its value. Only in methods, used very little
        Debug.Log($"A var variable like newAge, which value is {newAge} , take any value type");
        
        // String concatenations:
        Debug.Log($"This string has variables such as {firstName} or {pi} inserted inside it"); // Usually used 
        Debug.Log("This string has variables such as " + firstName + " or " + pi + " inserted inside it");

        ComputeAge(); // Call for a method
        CreateCharacter();
        AddTwo(1,2); // Call for a method with parameters and return value

        int characterLevel = 50; // Variable to use as parameter of the method with the return value
        int newLevel = CreateCharacter("Lloyd Irving", characterLevel); // Save the return value in a variable. 
        Debug.Log(newLevel); 
        // This way is most used for its visibility and context

        Debug.Log(CreateCharacter("Garnet", characterLevel)); // Return the value directly to the method

        // *DOT NOTATION*: Dot syntax for accessing class, methods, variables, etc. 
        // Example: VariablesAndMethod.Arithmetic().currentvalue;
    }

    // Update is called once per frame
    void Update()
    {
        // Used to behaviours such as movements, jumps, etc.
    }

    /* METHODS:
    * Access modifiers (private / public / protected / internal)
    * Return value in the end of the method (void / data types / classes / enums / etc.)
    * Unique name of the method (always begins in uppercase and using Pascal Case)
    * Double brackets (voids / input parameters) 
    * Braces which enclose the method body
    * Each method has its own SIGNATURE
     
    - Declaration / Definition:
    accesModifier return UniqueName(parameterType parameterName)
    {
        method body
    } 

    - Call / Invoke: 
    UniqueName();    Void value
    UniqueName(parameterVariable);    With any data type to return     
    */
    
    // COMMENTS OUR METHODS USING A SUMMARY: 
    /// <summary>
    /// Calculates the sum of modified ages
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(currentAge + addedAge);
    }

    // Summary example with input parameters and return value:

    /// <summary>
    /// This method adds two numbers
    /// </summary>
    /// <param name="a">First addend</param>
    /// <param name="b">Second addend</param>
    /// <returns>Sum of the input parameters</returns>
    int AddTwo(int a, int b)
    {
        return a + b;
    }
    
    // TODO: Used when something has not been done previously for any reason and show the task with "to do" 

    void CreateCharacter()
    {
        // SCOPE VISIBILITY OF VARIABLES: Local Scope. Only usable inside this method
        string characterClass = "Viking Warrior";
        int characterHealth = 200;

        // *Local Scopes: Applicable to other scope types (loops, conditionals, etc.)
        
        Debug.Log(characterName + " is a " + characterClass + " who has " + characterHealth + " points of life.");
        // characterName usable in any field of this class, characterClass and characterHealth only in this method

        return; // End of the execution in the method (since its value is void)

        // These code lines will not run
    }

    public int CreateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0} - Level: {1}", name, level);

        return level + 5;
    }

}
