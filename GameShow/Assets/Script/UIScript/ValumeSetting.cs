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
    [SerializeField] private AudioClip Decide;
    [Header("BGM、SEそれぞれのAudioSource")]
    [Tooltip("AudioSourceはすべて同じコンポーネント名でMain CameraにComponentされていますが、" +
        "違うAudio Clipをそれぞれ別に使用する場合はそれぞれのAudioSourceをアタッチしてください。")]
    [SerializeField] private AudioSource BGMAudioSource;
    [SerializeField] private AudioSource SEAudioSource;
    [Header("BGM、SEそれぞれの音量調節用SliderUI")]
    [SerializeField] private Slider BGMSlider;
    [SerializeField] private Slider SESlider;


    //クリックすると設定確認用SEを１度再生する
    public void OnClickPlaySE()
    {
        SEAudioSource.PlayOneShot(Decide);
    }

    //BGMスライダーの値にAudioMixerのBGMのボリュームを連動させる
    public void AdjustmentBGM(float volume)
    {
        audioMixer.SetFloat("BGMVol", volume);
    }

    //SEスライダーの値にAudioMixerのSEのボリュームを連動させる
    public void AdjustmentSE(float volume)
    {
        audioMixer.SetFloat("SEVol", volume);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
