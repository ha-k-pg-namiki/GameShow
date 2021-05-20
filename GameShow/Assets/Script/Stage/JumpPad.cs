using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    //ジャンプする力の定義
    [SerializeField] private float JumpForce = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //もしプレイヤータグのオブジェクトに触れたら上に押し上げる
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(0, JumpForce, 0, ForceMode.Impulse);
        }
    }
}
