using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.Events;



public class Case_opening : MonoBehaviour

{
    [Header("Custom Event")]
    public UnityEvent myEvents;
    private void OnTriggerEnter(Collider other)

    {
        if (myEvents == null)
        {
            print("Trigger is triggered but myEvents was null");
        }

        else

        {
            print("Trigger is Activated. Triggering" + myEvents);
            myEvents.Invoke();
        }

    }

}