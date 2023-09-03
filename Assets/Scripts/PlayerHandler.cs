using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{

    [SerializeField] private GameObject operateModeButton;
    
  
    void OnTriggerStay(Collider other)
    {
       
        if (other.CompareTag("Patient"))
        {
            operateModeButton.SetActive(true);
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Patient"))
        {
            operateModeButton.SetActive(false);
        }
    }
}
