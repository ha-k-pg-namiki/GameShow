using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    //スコアとして表示するUIの各桁Image
    #region SCORE_UI
    [Header("スコアの各桁のUI")]
    [SerializeField] private Image    UI1;
    [SerializeField] private Image   UI10;
    [SerializeField] private Image  UI100;
    [SerializeField] private Image   UI1k;
    [SerializeField] private Image  UI10k;
    [SerializeField] private Image UI100k;
    [SerializeField] private Image   UI1m;
    [SerializeField] private Image  UI10m;
    [SerializeField] private Image UI100m;
    [SerializeField] private Image   UI1b;
    #endregion

    //スコアとして表示するUIの各桁Image
    #region SCORE_TEX
    [Header("数のテクスチャ")]
    [SerializeField] private Texture texDark0;
    [SerializeField] private Texture tex0;
    [SerializeField] private Texture tex1;
    [SerializeField] private Texture tex2;
    [SerializeField] private Texture tex3;
    [SerializeField] private Texture tex4;
    [SerializeField] private Texture tex5;
    [SerializeField] private Texture tex6;
    [SerializeField] private Texture tex7;
    [SerializeField] private Texture tex8;
    [SerializeField] private Texture tex9;
    #endregion






    //仮
    [SerializeField] private Text text;


    public static int score;



    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("SCORE", 0);
        PlayerPrefs.DeleteKey("SCORE");



        
    }

    //private void OnDestroy()
    //{
    //    PlayerPrefs.SetInt("SCORE", score);
    //    PlayerPrefs.Save();
    //}

    // Update is called once per frame
    void Update()
    {
        score += 1;

        text.text = "SCORE:" + score;

        //if (score == 1)
        //{
        //    GetComponent<Renderer>().material.mainTexture = tex1;
        //}

        








        //仮
        if (Input.GetKey(KeyCode.P))
        {
            PlayerPrefs.DeleteKey("SCORE");
            score = 0;
        }
    }


}
