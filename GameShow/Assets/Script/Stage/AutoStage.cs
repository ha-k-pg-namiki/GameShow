using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoStage : MonoBehaviour
{
    private int StageSize = 100;
    private int StageIndex;

    //player
    [SerializeField] private Transform Target;

    //ステージのプレハブ
    [SerializeField] private GameObject[] Stagenum;

    //スタート時にどのステージから作成するか
    [SerializeField] private int FirstStageIndex;

    //事前に生成しておくステージ
    [SerializeField] private int AheadStage;

    //生成するステージのリスト
    [SerializeField] private List<GameObject> StageList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        StageIndex = FirstStageIndex - 1;
        StageManager(AheadStage);
    }

    // Update is called once per frame
    void Update()
    {
        int TargetPosIndex = (int)(Target.position.z / StageSize);

        if (TargetPosIndex + AheadStage > StageIndex)
        {
            StageManager(TargetPosIndex + AheadStage);
        }
    }

    void StageManager(int maps)
    {
        if (maps <= StageIndex)
        {
            return;
        }

        //指定したステージまでの作成
        for(int i = StageIndex + 1; i <= maps; i++)
        {
            GameObject stage = MakeStage(i);

            StageList.Add(stage);
        }

        //古いステージの削除
        while(StageList.Count > AheadStage + 1)
        {
            DestroyStage();
        }

        StageIndex = maps;
    }

    //ステージの生成
    GameObject MakeStage(int index)
    {
        int NextStage = Random.Range(0, Stagenum.Length);

        GameObject StageObject = (GameObject)Instantiate(Stagenum[NextStage], new Vector3(0, 0, index * StageSize), Quaternion.identity);

        return StageObject;
    }

    //ステージの削除
    void DestroyStage()
    {
        GameObject OldStage = StageList[0];

        StageList.RemoveAt(0);

        Destroy(OldStage);
    }
}
