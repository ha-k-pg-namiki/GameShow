using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    [SerializeField] private GameObject Setting;

    //[SerializeField] private AudioClip SEOpen;
    //AudioSource audioSource;

    private GameObject SettingsInstance = null;




    public void OnClick()
    {
        if (Setting.activeInHierarchy == false)
        {
            //AudioSource audioSource = gameObject.GetComponent<AudioSource>();
            //audioSource.Play();

            Setting.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            Setting.SetActive(false);
            Time.timeScale = 1.0f;
        }
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
