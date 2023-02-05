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
    public float _rotationSpeed;
    public SpriteRenderer _viejito;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        Vector3 _movementdirection = new Vector3 (hor,0,ver);
        _movementdirection.Normalize();
        print("Hor:" +hor);
        print("Ver: " +ver);
        transform.Translate(_movementdirection * playerClases._speedMovement * Time.deltaTime, Space.World);
        /*if(hor <= 0 && ver <=0)
        {
            _viejito.flipX = true;
            _viejito.flipY = false;
        }
        else if(hor > 0 && ver <= 0)
        {
            _viejito.flipX = false;
            _viejito.flipY = false;
        }
        if(ver >= 0 && hor < 0)
        {
            _viejito.flipY = true;
        }
        else if(ver >= 0 && hor > 0)
        {
            _viejito.flipY = false;
        }*/
        //Rotar jugador
        if(_movementdirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(_movementdirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, _rotationSpeed * Time.deltaTime);
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
