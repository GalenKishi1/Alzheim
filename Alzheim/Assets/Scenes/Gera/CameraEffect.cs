using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AdaptivePerformance.VisualScripting;

public class CameraEffect : MonoBehaviour
{
    public GameObject _roomToDissapear;
    public GameObject _roomToAppear;
    public CinemachineVirtualCamera _newvirtualCamera;
    public CinemachineVirtualCamera _oldvirtualCamera;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            _roomToDissapear.SetActive(false);
            _roomToAppear.SetActive(true);


        }
    }
}
