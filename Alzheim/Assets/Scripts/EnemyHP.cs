using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public float HP = 100;

    void Update()
    {
        HP = Mathf.Clamp(HP, 0, 100);

        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void Quitarvida(float Damage)
    {
        HP = HP - Damage;
        if (HP <= 0)
        {
            FindObjectOfType<AudioManager>().Play("DeadEnemy");
        }
    }

}
