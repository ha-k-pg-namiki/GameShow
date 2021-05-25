using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPGauge : MonoBehaviour
{
    //HPゲージ本体
    [SerializeField] private Slider HPSlider;
    //HPの最大値
    [Header ("最大HP")]
    [SerializeField] private float maxHP = 100.0f;
    //HPの減少量
    [Header("HP減少量")]
    [SerializeField] private float DecreaseHP;
    //HPの増加量
    [Header("HP増加量")]
    [SerializeField] private float IncreaseHP;
    //罠によるHPの減少量
    [Header("罠によるダメージ量")]
    [SerializeField] private float DecreaseHPByTrap;

    //HPの現在値
    private float currentHP;

    // Start is called before the first frame update
    void Start()
    {
        //HPゲージを最大値に変更
        HPSlider.value = 1;

        //HPの現在値を最大値に変更
        currentHP = maxHP;

        //減少HPをHP最大値等と単位をそろえるために行う処理
        DecreaseHP /= 100;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //HPの減少を行う
        if (currentHP >= 0)
        {
            currentHP -= DecreaseHP;
        }

        //HPゲージ本体にHP状況を反映
        HPSlider.value = currentHP / maxHP;
    }

    private void Update()
    {
        
    }

    //HP回復アイテムを取得した際にHPを回復させる関数
    public void GetHPRecoverItem()
    {
        if (currentHP >= 0)
        {
            currentHP += IncreaseHP;

            //最大HPを超えないようにcurrentHPを調整
            if (currentHP > maxHP)
            {
                currentHP = maxHP;
            }
        }

        //HPゲージ本体にHP状況を反映
        HPSlider.value = currentHP / maxHP;
    }

    //Trapを取得した際にHPを減少させる関数
    public void GetTrap()
    {
        if (currentHP >= 0)
        {
            currentHP += (DecreaseHPByTrap * -1.0f);

            //最低HPを超えないようにcurrentHPを調整
            if (currentHP < 0.0f)
            {
                currentHP = 0.0f;
            }
        }

        //HPゲージ本体にHP状況を反映
        HPSlider.value = currentHP / maxHP;
    }
}
