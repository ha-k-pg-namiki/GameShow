using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessSetting : MonoBehaviour
{
    [Header("Hierarchyに存在するLightオブジェクト")]
    [SerializeField] private Light DirectLight;
    [Header("明るさ調節用SliderUI")]
    [SerializeField] private Slider BrightnessSilder;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DirectLight.intensity = BrightnessSilder.value;
    }
}
