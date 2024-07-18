using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopStatements : MonoBehaviour
{
    /* ITERATION STRUCTURES
       They allow a block of code to be executed repeatedly based on a specific condition 
       
    * FOR LOOP
    - It needs to know the start and end conditions to know how many times to run
    - It is usually used on arrays and lists to know how many times to iterate
    - The position of the elements is necessary
    - The sentence takes three expressions, which are made before the execution of the loop:
        - Initialiser: local variable which is used to carry the loop count (int i = 0)
        - Condition: boolean expression that is checked. If true, the iterator is followed, 
          if false, the loop ends (i < array.Length / list.Count)
        - Iterator: expression used to increment or decrement the initialiser (i++ / i--) 

    -Syntax:

    for (intialiser; condition; iterator)
    {
        Block of code to be executed;
    }

    * FOREACH LOOP
    - Takes all elements in a collection and stores them in a local variable
    - The local variable must be of the same data type as the collection
    - It is very accessible to pass element to element within a collection
    - The position of the elements is not necessary
    - It is particularly useful in dictionaries, as they are not based on indexes (these work with keys)
    - The "KeyValuePair" variable is used for dictionaries

    - Syntax:

    foreach (elementType localVariableName in colecctionVariable)
    {
        Block of code to be executed;
    }

    * WHILE LOOP
    - It is similar to an if statement
    - It runs while the condition is true
    - The initialiser goes before the loop
    - Inside the loop is the condition
    - The iterator is placed after the block of code

    -Syntax:

    initialiser
    while (condition)
    {
        Block of code to be executed;
        iterator;
    }

    Operators in the loops
    - Increment operator: ++
    - Decrement operator: --
    */
    
    // LIST USED FOR EXAMPLES
    List<string> vikingCharacters = new List<string>() {"Ragnar", "Rollo", "Lagertha", "Floki", "Björn"}; // List

    // DICTIONARY USED FOR EXAMPLES
    Dictionary<string, int> itemsPrice = new Dictionary<string, int>() 
    {
        {"Long Sword", 250},
        {"Wood Shield",35},
        {"Magic Potion", 200},
        {"Bombs", 15},
        {"Arcane Diamond", 100000}
    };
    
    void Start()
    {
        // FOR: Checking the whole list

        for (int i = 0; i < vikingCharacters.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, vikingCharacters[i]); // Print values from the list
            // Index: 0- Ragnar, 1- Rollo, 2- Lagertha, 3- Floki, 4- Björn

            // Search for a specific member in the list
            if(vikingCharacters[i] == "Lagertha")
            {
                Debug.Log("The famous shield maiden is here!"); 
                // Index: 0- Ragnar, 1- Rollo, The famous shield maiden is here!
                break; // If it finds the member it is looking for, the execution stops, no more members are sought
            }
        }

        // FOREACH: Checking the whole list

        foreach (string character in vikingCharacters) // Each element in the collection is stored in a variable
        {
            Debug.LogFormat("{0} is ready for battle!", character); // All elements are displayed 
        }

        // FOREACH: Example with the dictionary

        int coins = 200; // Variable to check which items can be bought

        foreach(KeyValuePair<string, int> kvp in itemsPrice) // KeyValuePair to store both values (string and int)
        {
            Debug.LogFormat("The price of the item {0} is {1} gold coins", kvp.Key, kvp.Value);
            // Item and price aree displayed. Variable kvp requires both Key and Value properties

            if(kvp.Value <= coins) // kvp.Value: item prices. If they are less than or equal to coins (200)...
            {
                Debug.Log($"You can buy the item {kvp.Key}"); // These items can be bought
            }
            else
            {
                Debug.Log($"You cannot buy the item {kvp.Key}"); // These items cannot bought
            }
            
        }

        // WHILE: Example

        int playerLives = 3; // Initialiser: variable to check the number of lives 

        while(playerLives > 0) // While the numer of lives is greater than 0...
        {
            Debug.Log("Player is still alive"); // There are lives, player is alive
            playerLives--; // Lives are increased by 1 through the loop (3-1, 3-2, 3-1)
        }

        Debug.Log("Player is dead. Game Over"); // When there are no lives left, it goes out of the loop 
    }

    
}
