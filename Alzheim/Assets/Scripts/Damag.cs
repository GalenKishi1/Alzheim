using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyHP>().Quitarvida(10);
            Debug.Log("-50");
        }
    }
    
}