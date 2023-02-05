using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPManipulator1 : MonoBehaviour
{
    PlayerHP HPplayer;
    public int amount;
    public float damageTime;
    float currentDamageTime;

    void Start()
    {
        HPplayer = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHP>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            currentDamageTime += Time.deltaTime;
            if (currentDamageTime > damageTime)
            {
                HPplayer.HP += amount;
                currentDamageTime = 0.0f;
            }
        }
        if (other.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
