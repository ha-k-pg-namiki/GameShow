﻿using System.Collections;
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

        //減少HPをHP最大値等と単位をそろえるために行う
        DecreaseHP /= 100;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (currentHP >= 0)
        {
            currentHP -= DecreaseHP;
        }

        //HPゲージ本体にHP状況を反映
        HPSlider.value = currentHP / maxHP;
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        //Trapタグをもつオブジェクトに接触した場合、HPを一定量減少させる
        if (this.gameObject.CompareTag("Trap"))
        {
            currentHP -= DecreaseHPByTrap;
        }
    }
}
