using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesHP : MonoBehaviour
{
    public float _enemyLife;
    public PlayerClasses _playerClasses;

    private void Update()
    {
        if (_enemyLife <= 0)
        {
            Die();
        }
    }

   public void ReceiveDamage()
    {
        _enemyLife -= _playerClasses._attack;
        print("recibiendodanio");
    }

    void Die()
    {
        Destroy(gameObject, 0.5f);
    }
}
