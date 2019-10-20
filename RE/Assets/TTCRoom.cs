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
    public GameObject ClsTTCBtn;
    public GameObject[] TTCResults = new GameObject[2];

    public GameObject[] MovingView = new GameObject[2];
    public GameObject LookLeftBtn;
    public GameObject LookRightBtn;
    public int dir = 0;

    // Start is called before the first frame update
    void Start()
    {
        StoryBtn.SetActive(true);
        for (int i = 0; i < 3; i++)
        {
            CharOS[i].SetActive(false);
        }

        TTCBtn.SetActive(false);
        ClsTTCBtn.SetActive(false);
        for (int i = 0; i < 2; i++)
        {
            TTCResults[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (dir == -1)
        {
            Vector3 NewPos = MovingView[0].transform.position + new Vector3(0.3f, 0, 0);
            if (NewPos.x <= 5)
            {
                for (int i = 0; i < 2; i++) MovingView[i].transform.position += new Vector3(0.3f, 0, 0);
            }
        }
        if(dir == 1)
        {
            Vector3 NewPos = MovingView[0].transform.position - new Vector3(0.3f, 0, 0);
            if (NewPos.x >= -5)
            {
                for (int i = 0; i < 2; i++) MovingView[i].transform.position -= new Vector3(0.3f, 0, 0);
            }
        }
    }

    public void GoLeft()
    {
        dir = -1;
    }

    public void GoRight()
    {
        dir = 1;
    }

    public void LeftStop()
    {
        dir = 0;
    }

    public void RightStop()
    {
        dir = 0;
    }
    /*
    public void LookLeft()
    {
        for(int i=0;i<2;i++)
        {
            Vector3 NewPos = MovingView[i].transform.position += new Vector3(1, 0, 0);
            
        }
    }

    public void LookRight()
    {
        for (int i = 0; i < 2; i++)
        {
            Vector3 NewPos = MovingView[i].transform.position -= new Vector3(1, 0, 0);
            
        }
    }
    */
    public void OpenTTCPanel()
    {
        TTCBtn.SetActive(false);
        TTCResults[TTCindex].SetActive(true);
        if (TTCindex == 0) ClsTTCBtn.SetActive(true);
        else StoryBtn.SetActive(true);
    }

    public void CloseTTCPanel()
    {
        ClsTTCBtn.SetActive(false);
        TTCResults[TTCindex].SetActive(false);
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
