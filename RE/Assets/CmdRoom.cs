using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CmdRoom : MonoBehaviour
{
    public GameObject StoryBtn;
    public GameObject[] CharOS = new GameObject[4];
    public int BtnCount = -1;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0;i < 4; i++)
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
                SceneManager.LoadScene("TTCRoom");
                break;
            default:
                break;
        }
    }
}
