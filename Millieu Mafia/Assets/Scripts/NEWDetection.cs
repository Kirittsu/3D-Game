using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWDetection : MonoBehaviour
{
    static public bool found = false;
    private void OntriggerEnter(Collider other)
    {
        



        if (other.name == "PlayerBody")
        {
            found = true;
        }


    }

    private void OnTriggerExit(Collider other)
    {
        found = false;
    }
}
