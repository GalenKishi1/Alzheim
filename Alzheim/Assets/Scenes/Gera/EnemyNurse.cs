using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyNurse : MonoBehaviour
{
    private float _life;
    [SerializeField] private GameObject _player;
    [SerializeField] private float _speed;

    private bool _isdead;
    [Header("Ataque")]
    //Ataque
    public int _attackDamage;
    public float attack_CooldownMain;
    public float _attackCooldownTime;
    public float _attackRange;

    [Header("Proyectil")]
    //Proyectil
    public GameObject start_Proyectil;
    public GameObject prefab_Proyectil;
    public float speed_Proyectil;


    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        transform.LookAt(_player.transform.position);

        //Verificar distacia entre el enemigo y el jugador
        float _distanceToPlayer = Vector3.Distance(_player.transform.position, this.gameObject.transform.position);
        //Buscalo y encuentralo
        if(_distanceToPlayer > _attackRange)
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }//Si está a rango dispara
        else
        {
            //Empezar el timer del ataque
            if(_attackCooldownTime > 0)
            {
                _attackCooldownTime -= Time.deltaTime;
            }
            else
            {
                _attackCooldownTime = attack_CooldownMain;
                AttackPlayer();
            }
        }
    }

    private void AttackPlayer()
    {
        GameObject _tempProyectil = Instantiate(prefab_Proyectil, start_Proyectil.transform.position, start_Proyectil.transform.rotation) as GameObject;
        //Agregarle fuerza con rigidbody
        Rigidbody rb = _tempProyectil.GetComponent<Rigidbody>();

        Vector3 playerDirection = _player.transform.position - rb.position;
        playerDirection.Normalize();
        float rotatespeed = 200f;
        float rotateAmount = Vector3.Cross(playerDirection, transform.forward).y;
        rb.angularVelocity = -Vector3.Cross(playerDirection, transform.forward) * rotatespeed;
        rb.velocity = transform.forward * speed_Proyectil;
        rb.AddForce(transform.forward * speed_Proyectil);

        // rb.transform.LookAt(player_Position);
        //Agregar fuerza a la bala
        //rb.AddForce(transform.forward  * speed_Proyectil);

        Destroy(_tempProyectil, 5.0f);

        // player.GetComponent<Renderer>().material.SetColor("_Color",Color.red);
        print("Lanzar proyectil");
    }
}
