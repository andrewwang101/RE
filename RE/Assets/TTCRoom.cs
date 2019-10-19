using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TTCRoom : MonoBehaviour
{
    public GameObject StoryBtn;
    public GameObject[] CharOS = new GameObject[3];
    public int TTCindex = 0;
    public GameObject TTCBtn;
    public GameObject CloseTTCBtn;
    public GameObject[] TTCResult = new GameObject[2];

    // Start is called before the first frame update
    void Start()
    {
        StoryBtn.SetActive(true);
        for (int i = 0; i < 3; i++)
        {
            CharOS[i].SetActive(false);
        }

        TTCBtn.SetActive(false);
        CloseTTCBtn.SetActive(false);
        for (int i = 0;i < 2;i++)
        {
            TTCResult[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenTTCPanel()
    {
        TTCResult[TTCindex].SetActive(true);
        if (TTCindex == 0) CloseTTCBtn.SetActive(true);
        else StoryBtn.SetActive(true);
        TTCBtn.SetActive(false);
    }

    public void CloseTTCPanel()
    {
        TTCResult[TTCindex].SetActive(false);
        StoryBtn.SetActive(true);
        TTCindex = 1;
    }

    public void CmdMainStory()
    {
        CmdRoom.BtnCount++;
        switch (CmdRoom.BtnCount)
        {
            case 6://看來是蒐集衛星資料的儀器
                CharOS[0].SetActive(true);
                break;

            case 7:
                CharOS[0].SetActive(false);
                StoryBtn.SetActive(false);//去和物品互動
                TTCBtn.SetActive(true);
                break;
            
            case 8://這顆衛星看起來有GNSS喔
                CharOS[1].SetActive(true);
                break;

            case 9:
                CharOS[1].SetActive(false);
                StoryBtn.SetActive(false);//去和物品互動
                TTCBtn.SetActive(true);
                break;

            case 10://喔喔???
                CharOS[2].SetActive(true);
                break;

            case 11:
                CharOS[2].SetActive(false);
                StoryBtn.SetActive(false);
                SceneManager.LoadScene("CmdRoom");
                break;

            default:
                CmdRoom.BtnCount--;
                break;
        }
    }
}
