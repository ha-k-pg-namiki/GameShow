using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
    //変更するImageコンポーネントがアタッチされたUIオブジェクト
    [SerializeField] private GameObject StartButtonImage;
    [SerializeField] private GameObject StartButtonEffectImage;

    //点滅速度
    private float FlashingSpeed = 2.5f;

    private float ChangeTime;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeTime += Time.deltaTime * FlashingSpeed;
        //アルファ値のみを変更
        StartButtonImage.GetComponent<Image>().color = new Color(255.0f, 255.0f, 255.0f, Mathf.Sin(ChangeTime));
        StartButtonEffectImage.GetComponent<Image>().color = new Color(255.0f, 255.0f, 255.0f, Mathf.Sin(ChangeTime));

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();

            Debug.Log("ゲームを終了しました");
        }
    }
}
