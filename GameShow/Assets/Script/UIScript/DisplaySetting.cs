using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaySetting : MonoBehaviour
{
    [Header("残Time、スコアUIそれぞれのON、OFFを切り替えるためのボタン")]
    [SerializeField] private GameObject   TimeUIButtonON;
    [SerializeField] private GameObject  TimeUIButtonOFF;
    [SerializeField] private GameObject  ScoreUIButtonON;
    [SerializeField] private GameObject ScoreUIButtonOFF;
    [Header("それぞれのボタンに対応する選択されたことを示すテクスチャ")]
    [SerializeField] private GameObject SelectButtonA;
    [SerializeField] private GameObject SelectButtonB;
    [SerializeField] private GameObject SelectButtonC;
    [SerializeField] private GameObject SelectButtonD;
    [Header("表示/非表示にするスコアボード、HPゲージ")]
    [SerializeField] private GameObject ScoreBoard;
    [SerializeField] private GameObject    HPGauge;

    /*
     * 設定UIの残TimeをONにしたときに、次の動作を行う関数
     * [1] 選択されたことを示すテクスチャに切り替える
     * [2] HPゲージを表示する
     */
    public void OnClickTimeONButton()
    {
        SelectButtonB.SetActive(false);
        SelectButtonA.SetActive(true);

        HPGauge.SetActive(true);
    }

    /*
     * 設定UIの残TimeをOFFにしたときに、次の動作を行う関数
     * [1] 選択されたことを示すテクスチャに切り替える
     * [2] HPゲージを非表示にする
     */
    public void OnClickTimeOFFButton()
    {
        SelectButtonA.SetActive(false);
        SelectButtonB.SetActive(true);

        HPGauge.SetActive(false);
    }

    /*
     * 設定UIのスコアをONにしたときに、次の動作を行う関数
     * [1] 選択されたことを示すテクスチャに切り替える
     * [2] スコアボードを表示する
     */
    public void OnClickScoreONButton()
    {
        SelectButtonD.SetActive(false);
        SelectButtonC.SetActive(true);

        ScoreBoard.SetActive(true);
    }

    /*
     * 設定UIのスコアをOFFにしたときに、次の動作を行う関数
     * [1] 選択されたことを示すテクスチャに切り替える
     * [2] スコアボードを非表示にする
     */
    public void OnClickScoreOFFButton()
    {
        SelectButtonC.SetActive(false);
        SelectButtonD.SetActive(true);

        ScoreBoard.SetActive(false);
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
