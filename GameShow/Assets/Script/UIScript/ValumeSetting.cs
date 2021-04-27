using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class ValumeSetting : MonoBehaviour
{
    [SerializeField] private GameObject ValumeSettings;

    [SerializeField] private AudioMixerSnapshot Snapshot;
    [SerializeField] private AudioMixerSnapshot OptionSnapshot;

    [SerializeField] private AudioMixer audioMixer;

    //[SerializeField] private AudioClip[] BGMClips;
    //[SerializeField] private AudioSource audioSourceBGM;

    [SerializeField] private AudioClip SE01;
    AudioSource audioSource;






    [SerializeField] private Slider BGMSlider;


    

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.I))
        {
            audioSource.PlayOneShot(audioSource.clip);
        }

        if (ValumeSettings.activeSelf)
        {
            OptionSnapshot.TransitionTo(0.01f);
        }
        else
        {
            Snapshot.TransitionTo(0.01f);
        }



    }


    public void SetMaster(float volume)
    {
        audioMixer.SetFloat("MasterVol", volume);
    }

    public void SetBGM(float volume)
    {
        audioMixer.SetFloat("BGMVol", volume);
    }

    public void SetSE(float volume)
    {
        audioMixer.SetFloat("SEVol", volume);
    }


}
