// LIBRARIES AND NAMESPACES
using System.Collections; 
using System.Collections.Generic;
// Both are required for lists.
using UnityEngine; // Namespace for Unity

public class DataStructures : MonoBehaviour
{
    // DATA STRUCTURES (Array, List, Dictionary)
    /*
    * ARRAY. Features:
    - [value1, value2, value3, etc.]  Values = elements inside the brackets []
    - Homogeneous: It can store any type of element, but they all must all be of the same type
    - The length is set at creation and cannot be changed 
    - If initialised as empty, they are assigned a default value (0, "", null)
    - Each element of the array is stored in the order in which it was assigned
         - Index (where the elements are located): Positions -> [0] [1] [2] [3] (the first position is 0)
         - Index == Subscript

    - Syntax: 
      elemntType[] uniqueName = new elemntType[numberOfElements]; -> Basic syntax
      elemntType[] uniqueName = {element1, element2, element2}; -> Current
      int[] topScoresWithData = new int[] {element1, element2, element2}; -> Legacy 
      */

     int[] topScores = new int [3]; // Three elements, default values [0,0,0]
     int[] topScoresWithData = {920, 624, 512}; // Three values assigned. Index: 0 (920), 1 (624), 2 (512)
     // int[] topScoresWithData = new int[] {920, 624, 512}; -> The same in legacy


    /* 
    * LIST. Features:
    - Homogeneous: It can store any type of element, but they all must all be of the same type
    - Dynamic: elements can be added, extracted or updated. May grow or shrink
    - Less efficient in accessing elements. Memory overhead: possible efficiency issues if changed too much
    - When declarated, it is always empty (no elements)
    - Each element of the list is stored in the order in which it was assigned (Also start from Index 0)
    - It uses diamond brackets or angle brackets <>

    -Syntax:
     List<elementType> uniqueName = new List <elementType>();
          -No elements
     List<elementType> uniqueName = new List <elementType>() {element1, element2}; 
          -With elements 
     */

     List<int> partyNumbers = new List<int>(); // Declaration
     List<string> hyruleCharacters = new List<string>() {"Link", "Zelda", "Ganondorf"}; // Initialization

     /* 
    * DICTIONARY. Features:
    - Heterogeneous: Can store any type of value, not necessarily the same type
    - Dynamic: elements can be added, extracted or updated. May grow or shrink
    - Elements are set in pairs: KEY and VALUE (each key has a value) Both in braces {}
    - Keys must be unique and cannot be changed
    - It has no preset order. Can be ordered with methods
    - Less efficient in accessing elements. Memory overhead: possible efficiency issues if changed too much
    - When declarated, it is always empty (no elements)
    - It uses diamond brackets or angle brackets <>
    
     -Syntax:
     Dictionary<keyType, valueType> uniqueName = new Dictionary <keyType, valueType>();
          -No elements
     Dictionary<keyType, valueType> uniqueName = new Dictionary <keyType, valueType>()
     {
          {key1, value1},
          {key2, value2}
     };                                          
          -With elements
     */

     Dictionary<string, int> healthInventory = new Dictionary<string, int>() // Initialization
     {
          {"Potion", 5}, // KEY: Item name, VALUE: Number of items remaining
          {"Antidote", 3},
          {"Revive", 2}
     };
    

    void Start()
    {
        // ARRAY EXAMPLES:

        //Get the element at the second position stored in a variable
        int score = topScoresWithData [1]; // Index 1, Second position
        Debug.Log(score); // 624

        //Modify elements
        topScoresWithData [1] = 1001; // int[] topScoresWithData = {920, 1001, 512}
        Debug.Log(topScoresWithData[1]); 
        /* Debug.Log(topScoresWithData[3]); Invalid value. Element that does not exist (0,1,2)
                                            Error: Index was outside the bounds of the array (max. [2]) */

        // Checking the number of elements in the array. "Length" Property is its total size 
        Debug.LogFormat("The Numbers within this array are {0}", topScoresWithData.Length); 
        

        // LIST EXAMPLES:
        
        // Checking the number of elements in the list. "Count" Property is its total size 
        Debug.LogFormat("The number of main characters in The Legend of Zelda is: {0}", hyruleCharacters.Count);
        Debug.Log(hyruleCharacters[2]); // Checking a list element with brackets []. Ganondorf

        // Possible CHANGES in a list

        // Add a new element using the "Add()" method, and it will be in the last Index 
        hyruleCharacters.Add("Epona"); // {"Link", "Zelda", "Ganondorf", "Epona"};

        // Add a new element to a certain index using the "Insert()" method (Index, name)
        hyruleCharacters.Insert(2, "Midna"); // {"Link", "Zelda", "Midna", "Ganondorf", "Epona"};
        // Elements move to the right when a particular index is selected. All indexes increase by one unit

        // Delete elements, either by value or index using "Remove" or "RemoveAt()" method
        hyruleCharacters.Remove("Zelda"); // {"Link", "Midna", "Ganondorf", "Epona"};
        hyruleCharacters.RemoveAt(3); // {"Link", "Midna", "Ganondorf"};

        Debug.Log(hyruleCharacters); // Final result after changes

        // Checking each element in the list using the foreach loop
        for (int i = 0; i < hyruleCharacters.Count; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, hyruleCharacters[i]); // Print values from the list
        }

        
        // DICTIONARY EXAMPLES:

        // Checking the number of elements in the Dictionary. "Count" Property is its total size 
        Debug.LogFormat("The items in the health inventory are: {0}", healthInventory.Count); // Three items

        // Checking the value of a particular key
        int numberOfPotions = healthInventory["Potion"]; // Number of potions stored in a variable
        Debug.LogFormat("I have {0} potions left in my inventory", numberOfPotions); // 5 potions left

        // Possible CHANGES in a dictionary

        // Decreased inventory value for the key potion
        healthInventory["Potion"] -= 2; // 2 potions consumed (5 = 5 - 2)
        Debug.LogFormat("I have {0} potions left in my inventory", healthInventory["Potion"]); // 3 potions left

        // Creation of new elements

        // Adding new element
        healthInventory["Bandage"] = 2; // // {"Potion", 3}, {"Antidote", 3}, {"Revive", 2}, {"Bandage", 2};

        // Using the Add() method
        healthInventory.Add("Anti-Scald", 6); 
        // {"Potion", 3}, {"Antidote", 3}, {"Revive", 2}, {"Bandage", 2}, {"Anti-Scald", 6};

        // Checking if a key exists using the ContainsKey() method
        if(healthInventory.ContainsKey("Anti-freeze")) // Suitable for safety
        {
          Debug.Log(healthInventory["Anti-freeze"]); // If it exists, it will be displayed
        }
        else
        {
          Debug.Log("This key does not exist"); // If it does not exist, this message will be displayed
        }

        // Delete a key using the Remove() method
        healthInventory.Remove("Revive"); // "Revive" has been cleared
        // {"Potion", 3}, {"Antidote", 3}, {"Bandage", 2}, {"Anti-Scald", 6};
        
     }

    
}
