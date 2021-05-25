using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class ValumeSetting : MonoBehaviour
{
    [Header("使用するAudioMixer")]
    [SerializeField] private AudioMixer audioMixer;
    [Header("設定確認用SE")]
    [SerializeField] private AudioClip TestSE;
    [Header("BGM、SEそれぞれのAudioSource")]
    [Tooltip("AudioSourceはMain CameraにComponentされているAudioSourceをアタッチしてください")]
    [SerializeField] private AudioSource SEAudioSource;
    [Header("BGM、SEそれぞれの音量調節用SliderUI")]
    [SerializeField] private Slider BGMSlider;
    [SerializeField] private Slider SESlider;


    //クリックすると設定確認用SEを１度再生する
    public void OnClickPlaySE()
    {
        SEAudioSource.PlayOneShot(TestSE);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        audioMixer.SetFloat("BGMVol", BGMSlider.value);
        audioMixer.SetFloat("SEVol",  SESlider.value);
    }
}
