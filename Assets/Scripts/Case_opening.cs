using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.Events;



public class Case_opening : MonoBehaviour

{


    public GameObject oOpening;
    private void OnTriggerEnter(Collider other)

    {
        oOpening.GetComponent<Animator>().Play("Armature|opening_anim");
    }

}