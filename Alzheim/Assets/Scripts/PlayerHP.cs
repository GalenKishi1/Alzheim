using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public float HP = 10;
    public Image LifeBar;

    void Update()
    {
        HP = Mathf.Clamp(HP, 0, 10);

        LifeBar.fillAmount = HP / 10;
        
        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
