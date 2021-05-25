using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroller : MonoBehaviour
{
    //背景のスクロールするスピード
    [SerializeField]private float Speed;
    //スクロールする背景
    [SerializeField] private GameObject BackGround;
    //PauseスクリプトのアタッチされたEventSystem
    [SerializeField] private GameObject EventSystem;
    //Pauseスクリプト
    private Pause Pause;
    //Pauseスクリプトから取得した現在のPauseの状況を反映するための変数
    private int PauseNumber;

    // Start is called before the first frame update
    void Start()
    {
        //EventSystemのPauseスクリプトを取得
        Pause = EventSystem.GetComponent<Pause>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;
        //PauseスクリプトのGetPauseStateから値を取得し、反映
        PauseNumber = Pause.GetPauseState;

        //もしPauseがOnの場合は背景を移動、Offの場合は静止させる
        if (PauseNumber == 0)
        {
            myTransform.localPosition =
            new Vector3(myTransform.localPosition.x + (Speed * -1.0f), myTransform.localPosition.y, myTransform.localPosition.z);
        }
        else
        {
            myTransform.localPosition =
            new Vector3(myTransform.localPosition.x, myTransform.localPosition.y, myTransform.localPosition.z);
        }

        //背景が左端まで移動した場合は次の背景の右に移動させる
        if (myTransform.localPosition.x < -1919.0)
        {
            BackGround.GetComponent<RectTransform>().anchoredPosition = new Vector3(1919.0f, 0.0f, 0.0f);
        }
    }
}
