using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Sound : MonoBehaviour
{
    [Header("使用するAudioMixer")]
    [SerializeField] private AudioMixer audioMixer;
    [Header("使用するAudioSource")]
    [SerializeField] private AudioSource SEAudioSource;
    [Header("SE 決定")]
    [SerializeField] private AudioClip SE1;
    [Header("SE 否定")]
    [SerializeField] private AudioClip SE2;



    //決定や表示の時のSEを鳴らす
    public void OnClickOpenSE()
    {
        SEAudioSource.PlayOneShot(SE1);
    }

    //否定や非表示の時のSEを鳴らす
    public void OnClickCloseSE()
    {
        SEAudioSource.PlayOneShot(SE2);
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
