using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
    //スコアとして表示する各桁のUI
    #region SCORE_UI
    [Header("スコアの各桁のUI")]
    [SerializeField] private GameObject UI1;
    [SerializeField] private GameObject UI10;
    [SerializeField] private GameObject UI100;
    [SerializeField] private GameObject UI1k;
    [SerializeField] private GameObject UI10k;
    [SerializeField] private GameObject UI100k;
    [SerializeField] private GameObject UI1m;
    [SerializeField] private GameObject UI10m;
    #endregion

    //スコアとして表示する各桁のUI
    #region SCORE_BEST_UI
    [Header("スコアの各桁のUI")]
    [SerializeField] private GameObject BestUI1;
    [SerializeField] private GameObject BestUI10;
    [SerializeField] private GameObject BestUI100;
    [SerializeField] private GameObject BestUI1k;
    [SerializeField] private GameObject BestUI10k;
    [SerializeField] private GameObject BestUI100k;
    [SerializeField] private GameObject BestUI1m;
    [SerializeField] private GameObject BestUI10m;
    #endregion

    //ステージ評価UIの各Image
    #region STAGE_EVALUATION
    [Header("各評価UI")]
    [SerializeField] private GameObject EvaluationS;
    [SerializeField] private GameObject EvaluationA;
    [SerializeField] private GameObject EvaluationB;
    [SerializeField] private GameObject EvaluationC;
    [SerializeField] private GameObject EvaluationD;
    #endregion

    //ステージ評価UIのポイントボーダー
    #region EVALUATION_POINT
    [Header("評価UIのポイントボーダー")]
    [SerializeField] private int RankS;
    [SerializeField] private int RankA;
    [SerializeField] private int RankB;
    [SerializeField] private int RankC;
    [SerializeField] private int RankD;
    #endregion



    //クリックするとゲームシーンに移動する関数
    public void OnClickNextGameButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    //クリックするとタイトルシーンに移動する関数
    public void OnClickBackTitleButton()
    {
        SceneManager.LoadScene("TitleScene");
    }

    private Image Image;

    private Sprite sprite;

    private int score;

    private int CalcScore;

    private int Number;

    private int BestScore = 0;

    private int CalcBestScore;

    private int BNumber;

    private int Timer;



    //スコアを各桁ごとに分ける関数
    private void DiscrimNumber()
    {
        Number = CalcScore % 10;
        CalcScore = CalcScore / 10;
    }

    //スコアを各桁ごとに分ける関数　ベストスコア用
    private void DiscrimBestNumber()
    {
        BNumber = CalcBestScore % 10;
        CalcBestScore = CalcBestScore / 10;
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

    //DiscrimBNumber関数で得た数字を元に、その数字に合う数字のテクスチャをspriteに設定する関数 ベストスコア用
    private void IdentifyBNumber()
    {
        if (BNumber == 0)
        {
            sprite = Resources.Load<Sprite>("0");
        }
        else if (BNumber == 1)
        {
            sprite = Resources.Load<Sprite>("1");
        }
        else if (BNumber == 2)
        {
            sprite = Resources.Load<Sprite>("2");
        }
        else if (BNumber == 3)
        {
            sprite = Resources.Load<Sprite>("3");
        }
        else if (BNumber == 4)
        {
            sprite = Resources.Load<Sprite>("4");
        }
        else if (BNumber == 5)
        {
            sprite = Resources.Load<Sprite>("5");
        }
        else if (BNumber == 6)
        {
            sprite = Resources.Load<Sprite>("6");
        }
        else if (BNumber == 7)
        {
            sprite = Resources.Load<Sprite>("7");
        }
        else if (BNumber == 8)
        {
            sprite = Resources.Load<Sprite>("8");
        }
        else if (BNumber == 9)
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

    //以下、それぞれのUIへIdentifyBNumber関数で得たテクスチャを設定する関数 ベストスコア用
    #region CHANGE_BEST_UI
    private void ChangeBestUI1()
    {
        IdentifyBNumber();
        Image = BestUI1.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeBestUI10()
    {
        IdentifyBNumber();
        Image = BestUI10.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeBestUI100()
    {
        IdentifyBNumber();
        Image = BestUI100.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeBestUI1k()
    {
        IdentifyBNumber();
        Image = BestUI1k.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeBestUI10k()
    {
        IdentifyBNumber();
        Image = BestUI10k.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeBestUI100k()
    {
        IdentifyBNumber();
        Image = BestUI100k.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeBestUI1m()
    {
        IdentifyBNumber();
        Image = BestUI1m.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeBestUI10m()
    {
        IdentifyBNumber();
        Image = BestUI10m.GetComponent<Image>();
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

    //テクスチャ設定関数を使用し、スコアを更新する関数 ベストスコア用
    private void DiscrimAndChangeBestUI()
    {
        CalcBestScore = BestScore;

        DiscrimBestNumber();

        ChangeBestUI1();

        DiscrimBestNumber();

        ChangeBestUI10();

        DiscrimBestNumber();

        ChangeBestUI100();

        DiscrimBestNumber();

        ChangeBestUI1k();

        DiscrimBestNumber();

        ChangeBestUI10k();

        DiscrimBestNumber();

        ChangeBestUI100k();

        DiscrimBestNumber();

        ChangeBestUI1m();

        DiscrimBestNumber();

        ChangeBestUI10m();

    }

    //各UIを表示していくコルーチン
    private IEnumerator ResultCor()
    {
        yield return new WaitForSeconds(1.0f);

        DiscrimAndChangeUI();

        yield return new WaitForSeconds(1.0f);

        DiscrimAndChangeBestUI();

        yield return new WaitForSeconds(1.0f);

        if (score >= RankD)
        {
            EvaluationD.SetActive(true);
        }

        yield return new WaitForSeconds(1.0f);

        if (score >= RankC)
        {
            EvaluationC.SetActive(true);
        }

        yield return new WaitForSeconds(1.0f);

        if (score >= RankB)
        {
            EvaluationB.SetActive(true);
        }

        yield return new WaitForSeconds(1.0f);

        if (score >= RankA)
        {
            EvaluationA.SetActive(true);
        }

        yield return new WaitForSeconds(1.0f);

        if (score >= RankS)
        {
            EvaluationS.SetActive(true);
        }

        yield return new WaitForSeconds(1.0f);
    }



    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("SCORE");

        EvaluationD.SetActive(false);
        EvaluationC.SetActive(false);
        EvaluationB.SetActive(false);
        EvaluationA.SetActive(false);
        EvaluationS.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        score = 41000;

        BestScore = 345678;


        if (BestScore < score)
        {
            BestScore = score;
            PlayerPrefs.SetInt("BEST_SCORE", BestScore);
            PlayerPrefs.Save();
        }

        StartCoroutine("ResultCor");
    }
}
