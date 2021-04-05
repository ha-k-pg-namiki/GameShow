using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeGravity : MonoBehaviour
{
    //重力の大きさ
    float Gravity = 7.0f;

    //重力が反転しているかどうか
    bool IsReverse = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.A))
        //{
        //    Physics.gravity = new Vector3(0, 10, 0);
        //}

        //反転していない重力
        if (IsReverse == false)
        {
            Physics.gravity = new Vector3(0, -Gravity, 0);
        }
        //反転している重力
        if (IsReverse == true)
        {
            Physics.gravity = new Vector3(0, Gravity, 0);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //反転ギミックと離れた瞬間の処理
        if (other.gameObject.tag == "ChangeGravity")
        {
            //反転していないなら反転させる
            if (IsReverse == false)
            {
                IsReverse = true;
            }
            //反転しているなら元に戻す
            else if (IsReverse == true)
            {
                IsReverse = false;
            }
        }
    }
}
