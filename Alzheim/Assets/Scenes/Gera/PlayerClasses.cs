using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClasses : MonoBehaviour
{
    //Stats del jugador
    //public enum PlayerClass {}
    public int _life, _attack, _rangeAttack, _speedMovement;
    public float _cooldownAttack;

    // Start is called before the first frame update
    void Start()
    {
        //EstadisticasBase();
    }


    public void EstadisticasBase()
    {
        //Estadisticas base
        _life = 3;
        _attack = 0;
        _rangeAttack = 0;
        _cooldownAttack = 0;
        _speedMovement = 2;
        print("Vida: " + _life + "Attaque: " + _attack);
    }

    public void UpdatePlayerClassValue(int classValue)
    {
        switch(classValue)
        {
            //Trote
            case 1:
                _attack =+ 3;
                _cooldownAttack = 1;
                break;
            //Bastón
            case 2:
                _speedMovement -= 1;
                _attack = +5;
                _cooldownAttack += 3;
                break;
            //Silla de ruedas
            case 3:
                _speedMovement = + 2;
                break;

        }
        print("Vida: " +_life  + "Attaque: " + _attack);
            
    }

    public void UpdateSecondPlayerClassValue(int secondClassValue)
    {
        switch(secondClassValue)
        {
            //Boxeador
            case 1:
                _attack = +2;
                _cooldownAttack -= 0.5f;
                break;
            //Karateka
            case 2:
                break;
            //Samurai
            case 3:
                break;
            //Rifle
            case 4:
                break;
            //Carro
            case 5:
                break;
            //Trasnformer
            case 6:
                break;
        }
    }
}
