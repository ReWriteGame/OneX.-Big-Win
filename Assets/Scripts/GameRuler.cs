using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRuler : MonoBehaviour
{
    [SerializeField] private Arrow arrow1;

    [SerializeField] private int myValue = 1;
    public void setValue(int value)
    {
        myValue = value;
    }



    public UnityEvent arrowCoincidedEvent;
    public UnityEvent arrowNotCoincidedEvent;


    public void checkMatch()
    {
        if (arrow1.collidedObject.GetComponent<Cell>().Value == myValue)
            arrowCoincidedEvent?.Invoke();
        else arrowNotCoincidedEvent?.Invoke();
    }
}
