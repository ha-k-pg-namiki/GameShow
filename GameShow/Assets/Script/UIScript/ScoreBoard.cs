using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    //スコア表示用テキストオブジェクトを設定
    [SerializeField] private Text text;

    [SerializeField] private GameObject Pause;

    //スコアとして表示する各桁のUI
    #region SCORE_UI
    [Header("スコアの各桁のUI")]
    [SerializeField] private GameObject    UI1;
    [SerializeField] private GameObject   UI10;
    [SerializeField] private GameObject  UI100;
    [SerializeField] private GameObject   UI1k;
    [SerializeField] private GameObject  UI10k;
    [SerializeField] private GameObject UI100k;
    [SerializeField] private GameObject   UI1m;
    [SerializeField] private GameObject  UI10m;
    #endregion

    [Header("スコアアップアイテムを取得した際の獲得スコア")]
    [SerializeField] private int ScoreUP;
    [Header("スコア減少アイテムを取得した際の減少スコア")]
    [SerializeField] private int ScoreDown;

    private Image Image;

    private Sprite sprite;

    private int score;

    private int CalcScore;

    private int Number;

    //スコアを各桁ごとに分ける関数
    private void DiscrimNumber()
    {
        Number = CalcScore % 10;
        CalcScore = CalcScore / 10;
    }

    //DiscrimNumber関数で得た数字を元に、その数字に合う数字のテクスチャをspriteに設定する関数
    private void IdentifyNumber()
    {
        if (Number == 0)
        {
            sprite = Resources.Load<Sprite>("0");
        }
        else if (Number == 1)
        {
            sprite = Resources.Load<Sprite>("1");
        }
        else if (Number == 2)
        {
            sprite = Resources.Load<Sprite>("2");
        }
        else if (Number == 3)
        {
            sprite = Resources.Load<Sprite>("3");
        }
        else if (Number == 4)
        {
            sprite = Resources.Load<Sprite>("4");
        }
        else if (Number == 5)
        {
            sprite = Resources.Load<Sprite>("5");
        }
        else if (Number == 6)
        {
            sprite = Resources.Load<Sprite>("6");
        }
        else if (Number == 7)
        {
            sprite = Resources.Load<Sprite>("7");
        }
        else if (Number == 8)
        {
            sprite = Resources.Load<Sprite>("8");
        }
        else if (Number == 9)
        {
            sprite = Resources.Load<Sprite>("9");
        }
    }

    //以下、それぞれのUIへIdentifyNumber関数で得たテクスチャを設定する関数
    #region CHANGE_UI
    private void ChangeUI1()
    {
        IdentifyNumber();
        Image = UI1.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeUI10()
    {
        IdentifyNumber();
        Image = UI10.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeUI100()
    {
        IdentifyNumber();
        Image = UI100.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeUI1k()
    {
        IdentifyNumber();
        Image = UI1k.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeUI10k()
    {
        IdentifyNumber();
        Image = UI10k.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeUI100k()
    {
        IdentifyNumber();
        Image = UI100k.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeUI1m()
    {
        IdentifyNumber();
        Image = UI1m.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeUI10m()
    {
        IdentifyNumber();
        Image = UI10m.GetComponent<Image>();
        Image.sprite = sprite;
    }
    #endregion

    //テクスチャ設定関数を使用し、スコアを更新する関数
    private void DiscrimAndChangeUI()
    {
        CalcScore = score;

        DiscrimNumber();

        ChangeUI1();

        DiscrimNumber();

        ChangeUI10();

        DiscrimNumber();

        ChangeUI100();

        DiscrimNumber();

        ChangeUI1k();

        DiscrimNumber();

        ChangeUI10k();

        DiscrimNumber();

        ChangeUI100k();

        DiscrimNumber();

        ChangeUI1m();

        DiscrimNumber();

        ChangeUI10m();
    }

    // Start is called before the first frame update
    void Start()
    {
        //スコアを初期化
        score = 0;
        PlayerPrefs.SetInt("SCORE", score);
    }
    // Update is called once per frame
    void Update()
    {
        if (Pause.activeSelf == true)
        {
            score += 0;
        }
        else if (Pause.activeSelf == false)
        {
            score += 1;
        }

        DiscrimAndChangeUI();
    }

    private void OnTriggerEnter(Collider collider)
    {
        //Score+タグをもつオブジェクトに接触した場合、スコアを一定量増加させる
        if (gameObject.CompareTag("Score+"))
        {
            score = score + ScoreUP;
        }

        //Score-タグをもつオブジェクトに接触した場合、スコアを一定量減少させる
        if (gameObject.CompareTag("Score-"))
        {
            score = score - ScoreDown;
        }
    }

    //スコアUPアイテムを取得した際スコアを増加させる関数
    public void GetScoreUpItem()
    {
        score += ScoreUP;
    }

    public int GetScore
    {
        get{
            return score;
        }
    }
}
