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

    //======================================================
    //coding by namiki

    //ヒエラルキーのEventSystem
    [SerializeField]private GameObject EventSystem;
    //ヒエラルキーのCamera
    [SerializeField] private GameObject MainCamera;

    //ScoreBoardスクリプトを使用するための変数
    private ScoreBoard ScoreBoardScript;
    //HPGaugeスクリプトを使用するための変数
    private HPGauge HPGaugeScript;

    //プレイヤーの座標を取得するための変数
    Transform PlayerTransform;
    //カメラの座標を取得するための変数
    Transform CameraTransform;
    //カメラの回転角度の変更に必要な変数
    private float RotationCameraZ;
    //リザルトシーンで使用する移動距離を計測する変数
    private int PlayerDistance;
    //表裏反転の状態をInsideOutScriptに伝えるための変数
    private int InsideOutNumber;

    //======================================================

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();//  rbにRigidbodyの値を代入する

        //======================================================
        //coding by namiki

        //変数にScoreBoardスクリプトを代入
        ScoreBoardScript = EventSystem.GetComponent<ScoreBoard>();
        //変数にHPGaugeスクリプトを代入
        HPGaugeScript = EventSystem.GetComponent<HPGauge>();
        //PlayerDistanceを初期化
        PlayerDistance = 0;
        //プレイヤーの位置情報を取得
        PlayerTransform = this.transform;
        //カメラの位置情報を取得
        CameraTransform = MainCamera.transform;
        //初期化
        InsideOutNumber = 0;
        speedUpStep = 1;
        //======================================================

    }

    // Update is called once per frame
    void Update()
    {
        //======================================================
        //coding by namiki

        //プレイヤーの位置情報を座標に変換、更新
        Vector3 PlayerPos = PlayerTransform.position;
        //プレイヤーのZ軸座標をint型に変換し、PlayerDistance変数に代入
        PlayerDistance = (int)PlayerPos.z;
        //InsideOutNumberの状態を常に更新
        if (InsideOutNumber == 0)
        {
            InsideOutNumber = 0;
        }
        else
        {
            InsideOutNumber = 1;
        }

        if (PlayerPos.x > 1.0f || PlayerPos.x < -1.0f)
        {
            PlayerTransform.transform.position = new Vector3(0.0f, PlayerPos.y, PlayerPos.z);
        }

        //======================================================

        //反転していない重力
        if (IsReverse == false)
        {
            Physics.gravity = new Vector3(0, -Gravity, 0);

            if (Grounded == true)//  もし、Groundedがtrueなら、
            {
                if (Input.GetKeyDown(KeyCode.Space))//  もし、スペースキーがおされたなら、  
                {
                    Grounded = false;//  Groundedをfalseにする
                    //rb.AddForce(Vector3.up * jumpPower);//  上にJumpPower分力をかける

                    //======================================================
                    //coding by namiki
                    rb.AddForce(new Vector3(0.0f, jumpPower, 0.0f), ForceMode.Impulse);
                    //======================================================
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
                    //rb.AddForce(Vector3.up * -jumpPower);//  上にJumpPower分力をかける

                    //======================================================
                    //coding by namiki
                    rb.AddForce(new Vector3(0.0f, -jumpPower, 0.0f), ForceMode.Impulse);
                    //======================================================
                }
            }
        }

    }

    private void FixedUpdate()
    {
        SpeedUpStep(speedUpStep);

        //transform.Translate(Position.x, Position.y, Position.z += Speed);

        //プレイヤーの位置情報を座標に変換、更新
        Vector3 PlayerPos = PlayerTransform.position;

        transform.position = new Vector3(PlayerPos.x, PlayerPos.y, PlayerPos.z + Speed);

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

            //======================================================
            //coding by namiki

            //反転した場合にPlayerの子となるカメラも反転してしまうため、カメラの位置を対応した形にする
            RotationCameraZ += 180.0f;
            CameraTransform.localRotation = Quaternion.Euler(0.0f,-90.0f,RotationCameraZ);

            //反転した場合に表裏反転した状態に更新する
            if (InsideOutNumber == 0)
            {
                InsideOutNumber = 1;
            }
            else
            {
                InsideOutNumber = 0;
            }
            //======================================================


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
        else 
        {
            Grounded = false;
        }


        //if (collision.gameObject.tag == "SpeedUp")
        //{
        //    speedUpStep = 2;
        //}


        //if (collision.gameObject.tag == "SpeedDown")
        //{
        //    speedUpStep = 1;
        //}
    }

    //======================================================
    //coding by namiki

    //衝突しないオブジェクトとの当たり判定
    private void OnTriggerEnter(Collider collider)
    {
        //Trapタグを持つオブジェクトに衝突した際にGetScoreUpItem関数を行う
        if (collider.CompareTag("TrapObj"))
        {
            HPGaugeScript.GetTrap();
        }

        //HPRecoverタグを持つオブジェクトに衝突した際にGetHPRecoverItem関数を行う
        if (collider.CompareTag("HPRecover"))
        {
            HPGaugeScript.GetHPRecoverItem();
        }

        //ScoreUpタグを持つオブジェクトに衝突した際にGetScoreUpItem関数を行う
        if (collider.CompareTag("ScoreUp"))
        {
            ScoreBoardScript.GetScoreUpItem();
        }

        //SpeedUpタグを持つオブジェクトに衝突した際にspeedUpStepを1増加させる
        if (collider.CompareTag("SpeedUp"))
        {
            speedUpStep += 1;

            if (speedUpStep > 4)
            {
                speedUpStep = 4;
            }
        }

        if (collider.CompareTag("SpeedDown"))
        {
            speedUpStep -= 1;

            if (speedUpStep < 1)
            {
                speedUpStep = 1;
            }
        }
    }

    //======================================================


    private void SpeedUpStep(int step)
    {
        switch(step)
        {
            case 1: Speed = 0.3f; break;
            case 2: Speed = 0.4f; break;
            case 3: Speed = 0.5f; break;
            case 4: Speed = 0.6f; break;
        }
    }

    //======================================================
    //coding by namiki
    
    //リザルトシーンに距離を伝えるためのgetter
    public int GetDistance
    {
        get
        {
            return PlayerDistance;
        }
    }

    //表裏反転の状態をInsideOutScriptに伝えるためのgetter
    public int GetInsideOutNumber
    {
        get
        {
            return InsideOutNumber;
        }
    }
    //======================================================

}
