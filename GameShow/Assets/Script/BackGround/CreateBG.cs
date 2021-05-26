using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBG : MonoBehaviour
{
    //背景の幅
    private int BGSize = 100;

    private int BGIndex;

    //player
    [SerializeField] private Transform Target;

    //背景のプレハブ
    [SerializeField] private GameObject[] BGnum;

    //スタート時にどの背景から作成するか
    [SerializeField] private int FirstBGIndex;

    //事前に生成しておく背景
    [SerializeField] private int AheadBG;

    //生成する背景のリスト
    [SerializeField] private List<GameObject> BGList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        BGIndex = FirstBGIndex - 1;
        BGManager(AheadBG);
    }

    // Update is called once per frame
    void Update()
    {
        int TargetPosIndex = (int)(Target.position.z / BGSize);

        if(TargetPosIndex + AheadBG > BGIndex)
        {
            BGManager(TargetPosIndex + AheadBG);
        }
    }

    void BGManager(int maps)
    {
        if(maps <= BGIndex)
        {
            return;
        }

        //指定した背景の生成
        for(int i = BGIndex + 1; i <= maps; i++)
        {
            GameObject bg = MakeBG(i);

            BGList.Add(bg);
        }

        //古い背景の削除
        while(BGList.Count > AheadBG + 1)
        {
            DestroyBG();
        }

        BGIndex = maps;
    }

    //背景の作成
    GameObject MakeBG(int index)
    {
        int NextBG = Random.Range(0, BGnum.Length);

        GameObject BGObject = (GameObject)Instantiate(BGnum[NextBG], new Vector3(-20, 0, index * BGSize), Quaternion.identity);

        return BGObject;
    }

    //背景の削除
    void DestroyBG()
    {
        GameObject OldBG = BGList[0];

        BGList.RemoveAt(0);

        Destroy(OldBG);
    }
}
