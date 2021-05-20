using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroller : MonoBehaviour
{
    [SerializeField]private float Speed;
    private int NumberOfSprite = 2;
    private float TexW;

    private float Timer;

    private Camera Camera;
    [SerializeField] private GameObject BackGround;
    RectTransform PosBG;

    private float PosXIdou = -5.0f;

    // Start is called before the first frame update
    void Start()
    {
        //    GameObject MainCamera = GameObject.Find("Main Camera");
        //    Camera = MainCamera.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (gameObject.tag == "ChangeGravity")
        //{
        //    Transform myTransform = this.transform;
        //    transform.position = new Vector3(myTransform.position.x * -1.0f, myTransform.position.y, myTransform.position.z);
        //}
        //PosBG.localPosition = new Vector3(0.0f, 0.0f, 0.0f);

        Transform myTransform = this.transform;
        //BackGround.GetComponent<RectTransform>().anchoredPosition =
        //    new Vector3(myTransform.position.x, myTransform.position.y, myTransform.position.z + PosXIdou);

        myTransform.localPosition = 
            new Vector3(myTransform.localPosition.x + (Speed * -1.0f), myTransform.localPosition.y, myTransform.localPosition.z);

        ////Vector3 TopLeftPos = Camera.ScreenToWorldPoint(Vector3.zero);

        if (myTransform.localPosition.x < -1919.0)
        {
            BackGround.GetComponent<RectTransform>().anchoredPosition = new Vector3(1919.0f, 0.0f, 0.0f);
        }
    }

    //private void OnBecameInvisible()
    //{
    //    Timer += Time.deltaTime;

    //    if (Timer > 3.0f)
    //    {
    //        Transform myTransform = this.transform;
    //        transform.position = new Vector3(myTransform.position.x + 1920.0f * NumberOfSprite, 0.0f, 0.0f);
    //    }
    //}
}
