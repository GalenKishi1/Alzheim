using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            SceneManager.LoadScene(1);
            Destroy(gameObject);
        }
        if (HP <= 0)
        {
            FindObjectOfType<AudioManager>().Play("OldMan dead");
        }
    }
}
