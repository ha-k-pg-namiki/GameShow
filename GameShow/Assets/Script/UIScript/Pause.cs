using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    //ポーズをした際に影響を受けるUI
    [SerializeField] private GameObject HPGauge;
    [SerializeField] private GameObject ScoreBoard;
    [SerializeField] private GameObject InsideOutPanel;
    //ポーズ画面をアクティブにするためのボタン
    [SerializeField] private GameObject PauseOpen;
    //ポーズしたときに表示するPauseUI
    [SerializeField] private GameObject PausePanel;
    //背景を停止させるために使用する変数
    private int PauseStateNumber;

    //ボタンを押すことでゲームプレイ用UIを非表示にし、ポーズUIを表示する
    //その際、ゲームを一時中断する
    public void OnClickOpenButton()
    {
        HPGauge.SetActive(false);
        ScoreBoard.SetActive(false);
        PauseOpen.SetActive(false);
        InsideOutPanel.SetActive(false);

        PausePanel.SetActive(true);

        PauseStateNumber = 1;

        Time.timeScale = 0.0f;
    }

    public void OnClickCloseButton()
    {
        HPGauge.SetActive(true);
        ScoreBoard.SetActive(true);
        PauseOpen.SetActive(true);
        InsideOutPanel.SetActive(true);

        PausePanel.SetActive(false);

        PauseStateNumber = 0;

        Time.timeScale = 1.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //背景の状態を受け渡すゲッター
    public int GetPauseState
    {
        get
        {
            return PauseStateNumber;
        }
    }

}
