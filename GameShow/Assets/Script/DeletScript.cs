using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Player")//  もしGroundというタグがついたオブジェクトに触れたら、
    //    {
    //        Destroy(this.gameObject);
    //    }
    //}

    //======================================================
    //coding by namiki

    //Playerタグの付いたオブジェクトがすり抜けた瞬間にこのスクリプトがアタッチされたオブジェクトをヒエラルキーから削除する
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
    }

    //======================================================
}
