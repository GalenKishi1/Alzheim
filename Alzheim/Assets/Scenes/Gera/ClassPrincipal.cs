using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassPrincipal : MonoBehaviour
{

    [SerializeField] private int indexClass;
    [Space(2)]
    [SerializeField] int _newLife, _newattack, _newrangeAttack, _newspeedMovement;
    [SerializeField] float _newCooldownAttack;
    [Header("Clases")]
    [SerializeField] private bool _isFirstClass;
    [SerializeField] private GameObject[] _newClasses;
    [SerializeField] private GameObject[] _otherClasses;
    [SerializeField] private GameObject[] _2ndClassesposition;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            print("ToqueClase");
            PlayerClasses _playerClasses = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerClasses>();
            //_playerClasses.UpdatePlayerClassValue(indexClass);
            //._playerClasses._life =+ _newLife;
            _playerClasses._attack += _newattack;
            _playerClasses._rangeAttack += _newrangeAttack;
            _playerClasses._speedMovement += _newspeedMovement;
            _playerClasses._cooldownAttack += _newCooldownAttack;

            if (_isFirstClass == true)
            {
                GameObject go = Instantiate(_newClasses[0]);
                go.transform.position = _2ndClassesposition[0].transform.position;
                GameObject go1 = Instantiate(_newClasses[1]);
                go1.transform.position = _2ndClassesposition[1].transform.position;

                Destroy(_otherClasses[0]);
                Destroy(_otherClasses[1]);
            }

            Destroy(this.gameObject);
            
            print(this.gameObject.name);
        }
    }
}
