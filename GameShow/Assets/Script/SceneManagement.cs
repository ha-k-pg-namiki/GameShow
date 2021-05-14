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




    // Start is called before the first frame update
    void Start()
    {
        Timer = 0;
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
                SceneManager.LoadScene("ResultScene");
            }
        }
    }
}
