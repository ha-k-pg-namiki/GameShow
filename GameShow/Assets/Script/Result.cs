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

    //ベストスコアとして表示する各桁のUI
    #region BEST_SCORE_UI
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

    //距離として表示する各桁のUI
    #region DISTANCE_UI
    [Header("距離の各桁のUI")]
    [SerializeField] private GameObject DistanceUI1;
    [SerializeField] private GameObject DistanceUI10;
    [SerializeField] private GameObject DistanceUI100;
    [SerializeField] private GameObject DistanceUI1k;
    [SerializeField] private GameObject DistanceUI10k;
    [SerializeField] private GameObject DistanceUI100k;
    [SerializeField] private GameObject DistanceUI1m;
    [SerializeField] private GameObject DistanceUI10m;
    #endregion

    //ベストの距離として表示する各桁のUI
    #region BEST_DISTANCE_UI
    [Header("距離の各桁のUI")]
    [SerializeField] private GameObject BestDistanceUI1;
    [SerializeField] private GameObject BestDistanceUI10;
    [SerializeField] private GameObject BestDistanceUI100;
    [SerializeField] private GameObject BestDistanceUI1k;
    [SerializeField] private GameObject BestDistanceUI10k;
    [SerializeField] private GameObject BestDistanceUI100k;
    [SerializeField] private GameObject BestDistanceUI1m;
    [SerializeField] private GameObject BestDistanceUI10m;
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

    //ステージ評価UI
    #region EVALUATION_POINT
    [Header("各評価UI")]
    [SerializeField] private int RankS;
    [SerializeField] private int RankA;
    [SerializeField] private int RankB;
    [SerializeField] private int RankC;
    [SerializeField] private int RankD;
    #endregion

    //共通の数字Image
    private Image Image;
    //共通の数字Sprite
    private Sprite sprite;

    //スコア用変数
    private int Score = 0;
    private int CalcScore;
    private int Number;

    //ベストスコア用変数
    private int BestScore = 0;
    private int CalcBestScore;
    private int BNumber;

    //距離用変数
    private int Distance = 0;
    private int CalcDistance;
    private int DistanceNumber;

    //最高距離用変数
    private int BestDistance = 0;
    private int CalcBestDistance;
    private int DistanceBNumber;




    //スコアを各桁ごとに分ける関数
    private void DiscrimNumber()
    {
        Number = CalcScore % 10;
        CalcScore = CalcScore / 10;
    }

    //ベストスコアを各桁ごとに分ける関数
    private void DiscrimBestNumber()
    {
        BNumber = CalcBestScore % 10;
        CalcBestScore = CalcBestScore / 10;
    }

    //距離を各桁ごとに分ける関数
    private void DiscrimDistanceNumber()
    {
        DistanceNumber = CalcDistance % 10;
        CalcDistance = CalcDistance / 10;
    }

    //最高距離を各桁ごとに分ける関数
    private void DiscrimDistanceBestNumber()
    {
        DistanceBNumber = CalcBestDistance % 10;
        CalcBestDistance = CalcBestDistance / 10;
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

    //DiscrimBNumber関数で得た数字を元に、その数字に合う数字のテクスチャをspriteに設定する関数
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

    //DiscrimNumber関数で得た数字を元に、その数字に合う数字のテクスチャをspriteに設定する関数
    private void IdentifyDistanceNumber()
    {
        if (DistanceNumber == 0)
        {
            sprite = Resources.Load<Sprite>("0");
        }
        else if (DistanceNumber == 1)
        {
            sprite = Resources.Load<Sprite>("1");
        }
        else if (DistanceNumber == 2)
        {
            sprite = Resources.Load<Sprite>("2");
        }
        else if (DistanceNumber == 3)
        {
            sprite = Resources.Load<Sprite>("3");
        }
        else if (DistanceNumber == 4)
        {
            sprite = Resources.Load<Sprite>("4");
        }
        else if (DistanceNumber == 5)
        {
            sprite = Resources.Load<Sprite>("5");
        }
        else if (DistanceNumber == 6)
        {
            sprite = Resources.Load<Sprite>("6");
        }
        else if (DistanceNumber == 7)
        {
            sprite = Resources.Load<Sprite>("7");
        }
        else if (DistanceNumber == 8)
        {
            sprite = Resources.Load<Sprite>("8");
        }
        else if (DistanceNumber == 9)
        {
            sprite = Resources.Load<Sprite>("9");
        }
    }

    //DiscrimNumber関数で得た数字を元に、その数字に合う数字のテクスチャをspriteに設定する関数
    private void IdentifyDistanceBNumber()
    {
        if (DistanceBNumber == 0)
        {
            sprite = Resources.Load<Sprite>("0");
        }
        else if (DistanceBNumber == 1)
        {
            sprite = Resources.Load<Sprite>("1");
        }
        else if (DistanceBNumber == 2)
        {
            sprite = Resources.Load<Sprite>("2");
        }
        else if (DistanceBNumber == 3)
        {
            sprite = Resources.Load<Sprite>("3");
        }
        else if (DistanceBNumber == 4)
        {
            sprite = Resources.Load<Sprite>("4");
        }
        else if (DistanceBNumber == 5)
        {
            sprite = Resources.Load<Sprite>("5");
        }
        else if (DistanceBNumber == 6)
        {
            sprite = Resources.Load<Sprite>("6");
        }
        else if (DistanceBNumber == 7)
        {
            sprite = Resources.Load<Sprite>("7");
        }
        else if (DistanceBNumber == 8)
        {
            sprite = Resources.Load<Sprite>("8");
        }
        else if (DistanceBNumber == 9)
        {
            sprite = Resources.Load<Sprite>("9");
        }
    }


    //SCORE_UIのそれぞれのUIへIdentifyNumber関数で得たテクスチャを設定する関数
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

    //BEST_SCORE_UIのそれぞれのUIへIdentifyBNumber関数で得たテクスチャを設定する関数
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

    //DISTANCE_UIのそれぞれのUIへIdentifyDistanceNumber関数で得たテクスチャを設定する関数
    #region CHANGE_DISTANCE_UI
    private void ChangeDistanceUI1()
    {
        IdentifyDistanceNumber();
        Image = DistanceUI1.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeDistanceUI10()
    {
        IdentifyDistanceNumber();
        Image = DistanceUI10.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeDistanceUI100()
    {
        IdentifyDistanceNumber();
        Image = DistanceUI100.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeDistanceUI1k()
    {
        IdentifyDistanceNumber();
        Image = DistanceUI1k.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeDistanceUI10k()
    {
        IdentifyDistanceNumber();
        Image = DistanceUI10k.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeDistanceUI100k()
    {
        IdentifyDistanceNumber();
        Image = DistanceUI100k.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeDistanceUI1m()
    {
        IdentifyDistanceNumber();
        Image = DistanceUI1m.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeDistanceUI10m()
    {
        IdentifyDistanceNumber();
        Image = DistanceUI10m.GetComponent<Image>();
        Image.sprite = sprite;
    }
    #endregion

    //BEST_DISTANCE_UIのそれぞれのUIへIdentifyDistanceBNumber関数で得たテクスチャを設定する関数
    #region CHANGE_BEST_UI
    private void ChangeBestDistanceUI1()
    {
        IdentifyDistanceBNumber();
        Image = BestDistanceUI1.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeBestDistanceUI10()
    {
        IdentifyDistanceBNumber();
        Image = BestDistanceUI10.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeBestDistanceUI100()
    {
        IdentifyDistanceBNumber();
        Image = BestDistanceUI100.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeBestDistanceUI1k()
    {
        IdentifyDistanceBNumber();
        Image = BestDistanceUI1k.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeBestDistanceUI10k()
    {
        IdentifyDistanceBNumber();
        Image = BestDistanceUI10k.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeBestDistanceUI100k()
    {
        IdentifyDistanceBNumber();
        Image = BestDistanceUI100k.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeBestDistanceUI1m()
    {
        IdentifyDistanceBNumber();
        Image = BestDistanceUI1m.GetComponent<Image>();
        Image.sprite = sprite;
    }
    private void ChangeBestDistanceUI10m()
    {
        IdentifyDistanceBNumber();
        Image = BestDistanceUI10m.GetComponent<Image>();
        Image.sprite = sprite;
    }
    #endregion


    //テクスチャ設定関数を使用し、スコアを更新する関数
    private void DiscrimAndChangeUI()
    {
        CalcScore = Score;

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

    //テクスチャ設定関数を使用し、ベストスコアを更新する関数
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

    //テクスチャ設定関数を使用し、距離を更新する関数
    private void DiscrimAndChangeDistanceUI()
    {
        CalcDistance = Distance;

        DiscrimDistanceNumber();

        ChangeDistanceUI1();

        DiscrimDistanceNumber();

        ChangeDistanceUI10();

        DiscrimDistanceNumber();

        ChangeDistanceUI100();

        DiscrimDistanceNumber();

        ChangeDistanceUI1k();

        DiscrimDistanceNumber();

        ChangeDistanceUI10k();

        DiscrimDistanceNumber();

        ChangeDistanceUI100k();

        DiscrimDistanceNumber();

        ChangeDistanceUI1m();

        DiscrimDistanceNumber();

        ChangeDistanceUI10m();

    }

    //テクスチャ設定関数を使用し、最高距離を更新する関数
    private void DiscrimAndChangeDistanceBestUI()
    {
        CalcBestDistance = BestDistance;

        DiscrimDistanceBestNumber();

        ChangeBestDistanceUI1();

        DiscrimDistanceBestNumber();

        ChangeBestDistanceUI10();

        DiscrimDistanceBestNumber();

        ChangeBestDistanceUI100();

        DiscrimDistanceBestNumber();

        ChangeBestDistanceUI1k();

        DiscrimDistanceBestNumber();

        ChangeBestDistanceUI10k();

        DiscrimDistanceBestNumber();

        ChangeBestDistanceUI100k();

        DiscrimDistanceBestNumber();

        ChangeBestDistanceUI1m();

        DiscrimDistanceBestNumber();

        ChangeBestDistanceUI10m();

    }


    //各UIを表示していくコルーチン
    private IEnumerator ResultCor()
    {
        yield return new WaitForSeconds(1.0f);

        DiscrimAndChangeUI();

        yield return new WaitForSeconds(1.0f);

        DiscrimAndChangeBestUI();

        yield return new WaitForSeconds(1.0f);

        DiscrimAndChangeDistanceUI();

        yield return new WaitForSeconds(1.0f);

        DiscrimAndChangeDistanceBestUI();

        yield return new WaitForSeconds(1.0f);

        if (Score >= RankD)
        {
            EvaluationD.SetActive(true);
        }

        yield return new WaitForSeconds(1.0f);

        if (Score >= RankC)
        {
            EvaluationC.SetActive(true);
        }

        yield return new WaitForSeconds(1.0f);

        if (Score >= RankB)
        {
            EvaluationB.SetActive(true);
        }

        yield return new WaitForSeconds(1.0f);

        if (Score >= RankA)
        {
            EvaluationA.SetActive(true);
        }

        yield return new WaitForSeconds(1.0f);

        if (Score >= RankS)
        {
            EvaluationS.SetActive(true);
        }

        yield return new WaitForSeconds(1.0f);
    }


    // Start is called before the first frame update
    void Start()
    {
        Score = PlayerPrefs.GetInt("SCORE");
        BestScore = PlayerPrefs.GetInt("BEST_SCORE");
        Distance = PlayerPrefs.GetInt("DISTANCE");
        BestDistance = PlayerPrefs.GetInt("BEST_DISTANCE");

        EvaluationD.SetActive(false);
        EvaluationC.SetActive(false);
        EvaluationB.SetActive(false);
        EvaluationA.SetActive(false);
        EvaluationS.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (BestScore < Score)
        {
            BestScore = Score;
            PlayerPrefs.SetInt("BEST_SCORE", BestScore);
            PlayerPrefs.Save();
        }

        if (BestDistance < Distance)
        {
            BestDistance = Distance;
            PlayerPrefs.SetInt("BEST_DISTANCE", BestDistance);
            PlayerPrefs.Save();
        }

        StartCoroutine("ResultCor");
    }

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
}
