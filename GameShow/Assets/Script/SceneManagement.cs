using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    //ロードシーン遷移までの時間
    [SerializeField] private int LoadTime;

    //HPゲージ本体
    [SerializeField] private Slider HPSlider;

    int Timer;

    //ヒエラルキーのEventSystem
    [SerializeField] private GameObject EventSystem;
    //ヒエラルキーのPlayer
    [SerializeField] private GameObject Player;

    //ScoreBoardスクリプトを使用するための変数
    private ScoreBoard ScoreBoardScript;
    //Player Scriptスクリプトを使用するための変数
    private PlayerScript PlayerScript;
    //他のスクリプトから得た変数の値を保存しておくための変数
    private int Score;
    private int Distance;


    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;

        //変数にScoreBoardスクリプトを代入
        ScoreBoardScript = EventSystem.GetComponent<ScoreBoard>();
        //変数にHPGaugeスクリプトを代入
        PlayerScript = Player.GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "LoadScene")
        {
            Timer += 1;

            if (Timer == LoadTime)
            {
                SceneManager.LoadScene("GameScene");

                Timer = 0;
            }
        }

        if (SceneManager.GetActiveScene().name == "GameScene")
        {
            if (HPSlider.value == 0)
            {
                //各スクリプトから必要な変数の値を取得する
                Score = ScoreBoardScript.GetScore;
                Distance = PlayerScript.GetDistance;

                //各変数を保存する
                PlayerPrefs.SetInt("SCORE", Score);
                PlayerPrefs.SetInt("DISTANCE", Distance);
                PlayerPrefs.Save();

                SceneManager.LoadScene("ResultScene");
            }
        }
    }


    public void OnClickGoingGameSceneButton()
    {
        SceneManager.LoadScene("LoadScene");
    }

    public void OnClickGoingTitleSceneButton()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void OnClickGoingLoadSceneButton()
    {
        SceneManager.LoadScene("LoadScene");
    }
}
