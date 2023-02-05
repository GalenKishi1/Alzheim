using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPManipulator : MonoBehaviour
{
    PlayerHP HPplayer;
    public int amount;
    public float damageTime;
    float currentDamageTime;
   public bool _imABullet;

    void Start()
    {
        HPplayer = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHP>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            print("pegue");
            FindObjectOfType<AudioManager>().Play("SFX_Enfermera");
            currentDamageTime += Time.deltaTime;
            if (currentDamageTime > damageTime)
            {
                HPplayer.HP += amount;
                currentDamageTime = 0.0f;
            }
        }
        if(other.tag == "Player" && _imABullet == true)
        {
            FindObjectOfType<AudioManager>().Play("SFX_Enfermera");
            HPplayer.HP += amount;
            Destroy(this.gameObject);
        }
    }
}
