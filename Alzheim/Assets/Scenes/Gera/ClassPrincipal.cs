using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassPrincipal : MonoBehaviour
{

    [SerializeField] private int indexClass;
    [Space(2)]
    [SerializeField] int _newLife, _newattack, _newrangeAttack, _newspeedMovement;
    [SerializeField] float _newCooldownAttack;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerClasses _playerClasses = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerClasses>();
            //_playerClasses.UpdatePlayerClassValue(indexClass);
            _playerClasses._life =+ _newLife;
            _playerClasses._attack = _newattack;
            _playerClasses._rangeAttack = _newrangeAttack;
            _playerClasses._speedMovement = _newspeedMovement;
            _playerClasses._cooldownAttack = _newCooldownAttack;
        }
    }
}
