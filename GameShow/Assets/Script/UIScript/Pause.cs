using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    //ポーズをした際に影響を受けるUI
    [SerializeField] private GameObject HPGauge;
    [SerializeField] private GameObject ScoreBoard;
    //ポーズ画面をアクティブにするためのボタン
    [SerializeField] private GameObject PauseOpen;
    //ポーズしたときに表示するPauseUI
    [SerializeField] private GameObject PausePanel;

    //ボタンを押すことでゲームプレイ用UIを非表示にし、ポーズUIを表示する
    //その際、ゲームを一時中断する
    public void OnClickOpenButton()
    {
        HPGauge.SetActive(false);
        ScoreBoard.SetActive(false);
        PauseOpen.SetActive(false);

        PausePanel.SetActive(true);

        Time.timeScale = 0.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
