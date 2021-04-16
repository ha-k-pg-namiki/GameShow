using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //重力の大きさ
    float Gravity = 120.0f;

    //移動
    private Vector3 Position;

    //回転
    [SerializeField]
    private Vector3 Rotation;

    //重力が反転しているかどうか
    [SerializeField]
    bool IsReverse = false;

    private Rigidbody rb;//  Rigidbodyを使うための変数
    [SerializeField]
    private bool Grounded;//  地面に着地しているか判定する変数
    public float Jumppower;//  ジャンプ力

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();//  rbにRigidbodyの値を代入する
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

            if (Grounded == true)//  もし、Groundedがtrueなら、
            {
                if (Input.GetKeyDown(KeyCode.Space))//  もし、スペースキーがおされたなら、  
                {
                    Grounded = false;//  Groundedをfalseにする
                    rb.AddForce(Vector3.up * Jumppower);//  上にJumpPower分力をかける
                }
            }
        }
        //反転している重力
        if (IsReverse == true)
        {
            Physics.gravity = new Vector3(0, Gravity, 0);

            if (Input.GetKeyDown(KeyCode.Space))//  もし、スペースキーがおされたなら、  
            {
                Grounded = false;//  Groundedをfalseにする
                rb.AddForce(Vector3.up * -Jumppower);//  上にJumpPower分力をかける
            }
        }

        transform.Translate(Position.x, Position.y, Position.z);

        Position.z += 0.0001f;

        //回転
        transform.rotation = Quaternion.Euler(Rotation.x, Rotation.y, Rotation.z);
    }

    private void OnTriggerExit(Collider other)
    {
        //反転ギミックと離れた瞬間の処理
        if (other.gameObject.tag == "ChangeGravity")
        {
            //裏の世界に入った際さかさまになるので調整
            Rotation.z += 180.0f;

            //Gravity = 1000.0f;

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

    void OnCollisionEnter(Collision other)//  地面に触れた時の処理
    {
        if (other.gameObject.tag == "Ground")//  もしGroundというタグがついたオブジェクトに触れたら、
        {
            //Gravity = 100.0f;

            Grounded = true;//  Groundedをtrueにする
        }
    }
}
