using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour
{
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
