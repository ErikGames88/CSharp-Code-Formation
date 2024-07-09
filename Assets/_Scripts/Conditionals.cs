using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    // CONTROL OF FLOW STATEMENTS 

    /* IF - ELSE

    * if: condition which must be true to can run the code inside the braces (not neccesary with just one line)
    
    * else: if the condition is not true, other code is run (only on any conditions, not always)
    
    SYNTAX:

    if (certain true condition)
    {
        the condition is true and this code is running (condition has been fulfilled)
    } 
    else
    {
        the condition is not true and this code is running (condition has not been fulfilled)
    }   

    * else if: Another different condition within the first if

    DECISION TREES:
    
    * if nested within another if

    if (condition)
    {
        if (condition)
        {
        
        }
    }
    */

    /* 
    RATIONAL OPERATORS:
    * > greater than
    * < less than
    * >= greater than or equal to
    * <= less than or equal to
    * == equal to
    * != not equal to

    LOGICAL OPERATORS:
    * && AND: All conditions must be true
    * || OR: One or more conditions must be true
    * ! NOT: The condition is not (false)
       - !true = false
       - !false = true
       - if(!variable condition) the same: if(variable condition == false)

    * IMPORTANT: Multiple conditions can be mixed using and, or, not.
    */

    /*
    SWITCH:
    * Pattern matching: The way that Switch determines which case have to be run
    * The value condition to be evaluated must be the same as in the different cases
    * A value case that matches with the value condition will execute that code case
    * If it does not match, the code will not be executed and will end up (break)
    * If any case matches with the condition, the default code is executed (default = else)

    switch (Condition to be evaluated)
    {
        case value1:
            First case code
            break;
            
        case value2:
            Second case code
            break;
            
        default:
           Default code if it is not entered in any case
           breal;
           
    }
    */

    // Bool variables are used to conditionals
    public bool hasDungeonKey; 
    public string weaponType = "Arcane Sword";
    public int currentMoney = 36;
    public bool weaponEquipped;
    public string finalWeapon = "Diamond Sword";
    public string keyType = "Boss Key";

    public bool pureOfHeart = true;
    public bool hasSecretIncantation = false;
    public string rareItem = "Relic Stone";

    public string characterAction = "Attack";



    void Start()
    {
        // SIMPLE EXAMPLE:

        if (hasDungeonKey) // The same: if (hasDungeonKey == true) 
        {
            Debug.Log("You have got the sacred key, you can get in the cursed dungeon");
        }
        else 
        {
            Debug.Log("Your courage has not proven, you have to find the sacred key");
        }

        // ELSE - IF EXAMPLE USING MONEY:

        if(currentMoney > 50)
        {
            Debug.Log("You are rich!, watch out for the pickpockets!");
        }
        else if (currentMoney < 15)
        {
            Debug.Log("You need a job to earn some money...");
        }
        else // currentMoney is between 15 and 50
        {
            Debug.Log("You have saved money, look after it and do not spend it like crazy!");
        }

        // EXAMPLE USING NOT OPERATOR (!) CHECKING FALSE VALUES:

        if(!hasDungeonKey) // The same: if (hasDungeonKey == false)
        {
            Debug.Log("You did not have the secret key and cannot get in");
        }

        if(weaponType != "Ancient Spear") // Conditional variable is not equal than (!=)
        {
            Debug.Log("You have to find the suitable weapon to fight against the boss");
        }
        else
        {
            Debug.Log("You are ready for the battle!");
        }

        // DECISION TREES. NESTING EXAMPLE (AN IF WITHIN ANOTHER IF):

        if (weaponEquipped) // Check the first condition to see if it is fulfilled
        {
            if (finalWeapon == "Diamond Sword") // Check this nesting condition while the first condition is true
            {
                Debug.Log("For the King!"); // If the nesting condition is true, this message will be displayed
            }
            else
            {
                Debug.Log("This weapon is the wrong one"); // It is displayed if the nesting condition is false
            }
        }
        else // Only if the first condition is not true, it goes straight to the else 
        {
            Debug.Log("Your fists will be useless against the enemy armour");
        }

        // EXAMPLES USING AND, OR

        if (hasDungeonKey && keyType == "Boss Key") // Both conditions must be true
        {
            Debug.Log("You are ready to begin the final dungeon");
        }

        if (weaponType == "Arcane Sword" || finalWeapon == "Diamond Sword") //At least one condition must be true
        {
            Debug.Log("You got a powerful weapon");
        }

        OpenTreasureChamber();

        CharacterMovement();

        DiceExercise();

    }

    // TREASURE EXERCISE 
    void OpenTreasureChamber()
    {
        if (pureOfHeart && rareItem == "Relic Stone")
        {
            if (!hasSecretIncantation)
            {
                Debug.Log("You are pure and have the ancient item but you do not have the knowledge to enter");
            }
            else
            {
                Debug.Log("The Chamber Treasure is yours, brave warrior!");
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes to get in, you can do it!");
        }
    }

    // EXAMPLE WITH SWITCH
    public void CharacterMovement()
    {
        switch (characterAction) // The value condition (string type) 
        {
            // All of the cases below must also get string value 
            case "Heal": // Every case ends in colon
            Debug.Log("Using potions"); // Code to be executed if the case matches with the condition
            break; // Keyword to "break" the case if it does not match with the condition

            case "Defend":
            Debug.Log("Using shields");
            break;

            case "Attack": // *This value matches with the condition, so this code will be executed
            Debug.Log("Using weapons");
            break;

            default: // This case will be executed if no case matches the condition (like else)
            Debug.Log("Next turn");
            break;
    
        }
    }

    // FALL THROUGH CASES IN SWITCH
    // * Several cases are passed until there is a break
    public int diceRoll = 7; 
    public void DiceExercise()
    {
        switch (diceRoll)
        {
            // Along these cases it goes down to the right case or the break
            case 3:
            case 5:
            case 7: // This case matches the condition, but any of the others before the break are right too
            case 9:
            case 11:
            case 13:
            case 15:
            Debug.Log ("Normal Damage"); // This code runs in all previous cases, not just the 7 
            break;

            case 20:
            Debug.Log ("Critical damage");
            break;

            default:
            Debug.Log("You have failed and the enemy has attacked you");
            break;

        }
        
    } 

    
}
