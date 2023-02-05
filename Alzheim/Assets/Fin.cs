using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fin : MonoBehaviour
{
    [SerializeField] private GameObject _finCanvas;
    [SerializeField] private GameObject _creditosCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Time.timeScale = 0;
            _finCanvas.SetActive(true);
            
        }
    }


    public void GoToCredits()
    {
        _creditosCanvas.SetActive(true);
    }
    public void Exit_Button()
    {
        Debug.Log("Saliendo");
        Application.Quit();
    }
}
