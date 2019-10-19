using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainFunc : MonoBehaviour
{
    public GameObject PlayButton;
    public GameObject PrefButton;
    public GameObject QuitButton;

    //public GameObject LanguageButton;
    //public GameObject VolUpButton;
    //public GameObject VolDownButton;
    public GameObject BackButton;

    public GameObject Pref_Page;

    public static MainFunc Instance;
    public int language = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        //LanguageButton.SetActive(false);
        //VolUpButton.SetActive(false);
        //VolDownButton.SetActive(false);
        BackButton.SetActive(false);

        Pref_Page.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Opening");
    }

    public void Preference()
    {
        PlayButton.SetActive(false);
        PrefButton.SetActive(false);
        QuitButton.SetActive(false);

        //LanguageButton.SetActive(true);
        //VolUpButton.SetActive(true);
        //VolDownButton.SetActive(true);
        BackButton.SetActive(true);

        Pref_Page.SetActive(true);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Language_Toggle()
    {

    }

    public void VolumnUP()
    {

    }

    public void VolumnDown()
    {

    }

    public void BacktoMenu()
    {
        //LanguageButton.SetActive(false);
        //VolUpButton.SetActive(false);
        //VolDownButton.SetActive(false);
        BackButton.SetActive(false);

        PlayButton.SetActive(true);
        PrefButton.SetActive(true);
        QuitButton.SetActive(true);

        Pref_Page.SetActive(false);
    }

}
