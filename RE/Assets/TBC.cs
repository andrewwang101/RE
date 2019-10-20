using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TBC : MonoBehaviour
{
    public GameObject HomeBtn;
    public int BtnCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        BtnCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Home()
    {
        BtnCounter++;
        if(BtnCounter > 3)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
