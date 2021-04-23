using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //重力の大きさ
    private float Gravity = 120.0f;

    //座標
    [SerializeField]
    private Vector3 Position;

    //スピード
    [SerializeField]
    private float Speed;

    //スピードアップ段階
    [SerializeField]
    private int speedUpStep;

    //回転
    [SerializeField]
    private Vector3 Rotation;

    //重力が反転しているかどうか
    [SerializeField]
    bool IsReverse = false;

    private Rigidbody rb;//  Rigidbodyを使うための変数

    [SerializeField]
    private bool Grounded;//  地面に着地しているか判定する変数

    [SerializeField]
    private float jumpPower;//  ジャンプ力

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();//  rbにRigidbodyの値を代入する
    }

    // Update is called once per frame
    void Update()
    {

        }

    private void FixedUpdate()
    {

        
        //反転していない重力
        if (IsReverse == false)
        {
            Physics.gravity = new Vector3(0, -Gravity, 0);

            if (Grounded == true)//  もし、Groundedがtrueなら、
            {
                if (Input.GetKeyDown(KeyCode.Space))//  もし、スペースキーがおされたなら、  
                {
                    Grounded = false;//  Groundedをfalseにする
                    rb.AddForce(Vector3.up * jumpPower);//  上にJumpPower分力をかける
                }
            }
        }
        //反転している重力
        if (IsReverse == true)
        {
            Physics.gravity = new Vector3(0, Gravity, 0);

            if (Grounded == true)//  もし、Groundedがtrueなら、
            {

                if (Input.GetKeyDown(KeyCode.Space))//  もし、スペースキーがおされたなら、  
                {
                    Grounded = false;//  Groundedをfalseにする
                    rb.AddForce(Vector3.up * -jumpPower);//  上にJumpPower分力をかける
                }
            }
        }

        SpeedUpStep(speedUpStep);
        
        transform.Translate(Position.x, Position.y, Position.z += Speed);

        //Position.z += Speed;

        //回転
        transform.rotation = Quaternion.Euler(Rotation.x, Rotation.y, Rotation.z);

    }

    //Playeyと
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

    //当たり判定
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")//  もしGroundというタグがついたオブジェクトに触れたら、
        {
            //Gravity = 100.0f;

            Grounded = true;//  Groundedをtrueにする
            

        }


        if (collision.gameObject.tag == "SpeedUp")
        {
            speedUpStep = 2;
        }


        if (collision.gameObject.tag == "SpeedDown")
        {
            speedUpStep = 1;
        }

    }


   private void SpeedUpStep(int step)
    {
        switch(step)
        {
            case 1: Speed = 0.0002f; break;
            case 2: Speed = 0.0004f; break;
            case 3: Speed = 0.0008f; break;
            case 4: Speed = 0.001f; break;
        }
    }

}
