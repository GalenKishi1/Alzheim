using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    public PlayerClasses playerClases;
    private new Rigidbody rigidbody;
    public float movementSpeed;
    public GameObject _hit;
    public bool _canHit;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        if(hor != 0 || ver != 0)
        {
            Vector3 direction = (transform.forward * ver + transform.right * hor).normalized;

            rigidbody.velocity = direction * movementSpeed ;
        }

        if(_canHit == false)
        {
            AttackTimer();
        }
        if(_canHit == true && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
            playerClases._cooldownAttack = playerClases._mainCooldownAttack;
            _canHit = false;
        }
    }

    void AttackTimer()
    {
        if (playerClases._cooldownAttack > 0)
        {
            playerClases._cooldownAttack -= Time.deltaTime;
            _canHit = false;
        }
        else
        {
            _canHit =true;
        }
    }

    void Attack()
    {
       StartCoroutine( AttackDuration());
    }

   IEnumerator AttackDuration()
    {
        _hit.SetActive(true);
        yield return new WaitForSeconds(1f);
        _hit.SetActive(false);
    }

}
