using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroller : MonoBehaviour
{
    //座標を取得するための変数
    [SerializeField]private GameObject BackGround;
    Transform Transform;

    // Start is called before the first frame update
    void Start()
    {
        //位置情報を取得
        Transform = BackGround.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //位置情報を座標に変換、更新
        //Vector3 Pos = Transform.position;

        Transform.Translate(-0.1f, 0, 0);

        if (Transform.position.x < -960.0f)
        {
            Transform.position = new Vector3(1980.0f, 0, 0);
        }

        //if (Pos.x < -960.0f)
        //{
        //    Pos.x = 1920.0f;
        //}
    }
}
