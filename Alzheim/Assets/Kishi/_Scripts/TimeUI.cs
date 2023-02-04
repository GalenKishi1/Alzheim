using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class TimeUI : MonoBehaviour
{
    Image timeBar;
    public GameObject timesUpText;
    public float timeMax;
    private float timeInit = 0f;

    private void Start()
    {
        timesUpText.SetActive(false);
        timeBar = GetComponent<Image>();
        timeInit = timeMax;
        timesUpText.SetActive(true);
    }

    void Update()
    {
        if (timeInit > 0)
        {
            timeInit -= Time.deltaTime;
            timeBar.fillAmount = timeInit / timeMax;
        }
        else
        {
            Time.timeScale = 0;
        }

        if(timeBar.fillAmount == 0)
        {
            timeBar.fillAmount = 1;
        }
    }
}