using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class ActionScript : MonoBehaviour
{
    public enum ExecutionType {  Numbers, Actions, Both, None };
    public ExecutionType type;

    public int[] numbers;
    public UnityEvent[] actions = new UnityEvent[0];
    
    public void Play()
    {
        Debug.Log("Played Actions");

        if (type == ExecutionType.Both)
        {
            NumbersAndActions();
        }
        else if (type == ExecutionType.Numbers)
        {
            Numbers();
        }
        else if (type == ExecutionType.Actions)
        {
            Actions();
        }

       
        //When the condition is false, the for loop jumps here
    }
    void NumbersAndActions()
    { 
        //First Path : Initial condition
            //Second path: reoccurrence condition
            //Third Part: increment/decrement
            //n++ =( n += 1) = (n = n + 1)
            //for (int n = 0; n < 5; n++)
            //&& AND
            //|| OR
            //! NOT
            //
        for (int n = 0; n < actions.Length && n < numbers.Length; n++)
        {
           
            //Will Display nth value of numbers
            Debug.Log(numbers[n]);

            //Will execute nth unityevent
            actions[n].Invoke();
        }
    }

    void Numbers()
    {
        for (int n = 0;  n < numbers.Length; n++)
        {
            //Will Display nth value of numbers
            Debug.Log(numbers[n]);

            //Will execute nth unityevent
            actions[n].Invoke();
        }
    }

    void Actions()
    {
        for (int n = 0; n < actions.Length ; n++)
        {
            //Will Display nth value of numbers
            Debug.Log(numbers[n]);

            //Will execute nth unityevent
            actions[n].Invoke();
        }
    }

}
