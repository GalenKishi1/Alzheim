using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public float HP = 100;
    public Image LifeBar;

    void Update()
    {
        HP = Mathf.Clamp(HP, 0, 100);

        LifeBar.fillAmount = HP / 100;
        
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
