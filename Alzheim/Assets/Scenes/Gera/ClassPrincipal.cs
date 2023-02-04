using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassPrincipal : MonoBehaviour
{
    
    [SerializeField]private int indexClass;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerClasses _playerClasses = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerClasses>();
            _playerClasses.UpdatePlayerClassValue(indexClass);
        }
    }
}
