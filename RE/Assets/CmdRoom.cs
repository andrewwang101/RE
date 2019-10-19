using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CmdRoom : MonoBehaviour
{
    public GameObject StoryBtn;
    public GameObject[] CharOS = new GameObject[7];
    public static int BtnCount = -1;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;i < 7; i++)
        {
            CharOS[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CmdMainStory()
    {
        BtnCount++;
        switch(BtnCount)
        {
            case 0://看來是沒什麼訊號呢
                CharOS[0].SetActive(true);
                break;

            case 1://還是先到處看看吧
                CharOS[0].SetActive(false);
                CharOS[1].SetActive(true);
                break;

            case 2:
                CharOS[1].SetActive(false);
                //StoryBtn.SetActive(false);去解地圖任務
                break;

            case 3://看來和電腦一樣沒什麼資訊呢(地圖)
                CharOS[2].SetActive(true);
                break;

            case 4://不小心按到旁邊的按鈕，去看看吧
                CharOS[2].SetActive(false);
                CharOS[3].SetActive(true);
                break;

            case 5:
                CharOS[3].SetActive(false);
                StoryBtn.SetActive(false);
                SceneManager.LoadScene("TTCRoom");
                break;

            case 12://有訊號!!!
                CharOS[4].SetActive(true);
                break;

            case 13://能大概定位了
                CharOS[4].SetActive(false);
                CharOS[5].SetActive(true);
                break;

            case 14://資料似乎...
                CharOS[5].SetActive(false);
                CharOS[6].SetActive(true);
                break;

            case 15://To Be Continue...
                CharOS[6].SetActive(false);
                break;
            case 16://Back to Main Menu
                SceneManager.LoadScene("MainScene");
                break;

            default:
                BtnCount--;
                break;
        }
    }
}
