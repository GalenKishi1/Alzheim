using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject loading;
    public GameObject creditsPlus;
    public bool switchScene = false;
    public Animator animatorCloseCredits;
    public AudioManager audioManager;

    // Start is called before the first frame update

    private void Start()
    {
        FindObjectOfType<AudioManager>().Play("MusicMenu");
        print("Musicamenu");
    }
    public void Update()
    {
        if (switchScene == true) SceneManager.LoadScene("GameScene");

    }
    public void  Play_Button() 
    {
        FindObjectOfType<AudioManager>().StopSound("MusicMenu");
        loading.gameObject.SetActive(true);
        SceneManager.LoadScene(1);
    }

    public void Credits_Button()
    {
        creditsPlus.gameObject.SetActive(true);
    }

    public void Quit_Credits()
    {
        animatorCloseCredits.SetBool("PassToClose",true);
        StartCoroutine(JustExitCooldown());

    }

    public void Exit_Button()
    {
        Debug.Log("Saliendo");
        Application.Quit();
    }

    private IEnumerator JustExitCooldown()
    {
        yield return new WaitForSeconds(0.45f);
        creditsPlus.gameObject.SetActive(false);
    }
}
