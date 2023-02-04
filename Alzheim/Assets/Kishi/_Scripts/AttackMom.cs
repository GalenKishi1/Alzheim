using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackMom : MonoBehaviour
{
    public float time = 1f;
    public GameObject[] instanceAttack;

    // Start is called before the first frame update
    void Start()
    {
        for (int lector = 0; lector > instanceAttack.Length; lector++)
        {
            Debug.Log(instanceAttack);
        }
    }

    IEnumerator SpeedAttack()
    {
        yield return new WaitForSeconds(time);

    }
}
