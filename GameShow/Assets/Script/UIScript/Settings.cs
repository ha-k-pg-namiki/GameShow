using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    [Header("設定画面を開くためのボタン")]
    [SerializeField] private GameObject OpenSettingsButton;
    [Header("設定画面を閉じるためのボタン")]
    [SerializeField] private GameObject CloseSettingsButton;
    [Header("表示したい設定UIオブジェクト")]
    [SerializeField] private GameObject SettingsBoard;
    [Header("非表示したい設定UIオブジェクト")]
    [SerializeField] private GameObject PausePanel;
    [Header("各種設定UIに切り替えるためのボタン")]
    [SerializeField] private GameObject     VolumeButton;
    [SerializeField] private GameObject BrightnessButton;
    [SerializeField] private GameObject    DisplayButton;
    [SerializeField] private GameObject       HelpButton;
    [Header("各種設定UI本体")]
    [SerializeField] private GameObject     VolumeSetting;
    [SerializeField] private GameObject BrightnessSetting;
    [SerializeField] private GameObject    DisplaySetting;
    [SerializeField] private GameObject       HelpSetting;


    private Image Image;

    private Sprite sprite;

    //private GameObject SettingsInstance = null;

    //switch文でマジックナンバーを消すために使用する
    private enum SettingsState
    {
        Volume = 0, Brightness = 1, Display = 2, Help = 3
    }

    SettingsState state;

     /*
     * RestoreState関数
     * [1] 他の設定タブが選択された際に点灯テクスチャから消灯テクスチャに状態を戻す
     * [2] 消灯テクスチャに変更された設定タブのUIを非表示にする                      
     */
    private void RestoreState()
    {
        if (state == SettingsState.Volume)
        {
            sprite = Resources.Load<Sprite>("音量(消灯)");
            Image = VolumeButton.GetComponent<Image>();
            Image.sprite = sprite;

            VolumeSetting.SetActive(false);
        }
        else if (state == SettingsState.Brightness)
        {
            sprite = Resources.Load<Sprite>("輝度(消灯)");
            Image = BrightnessButton.GetComponent<Image>();
            Image.sprite = sprite;

            BrightnessSetting.SetActive(false);
        }
        else if (state == SettingsState.Display)
        {
            sprite = Resources.Load<Sprite>("表示(消灯)");
            Image = DisplayButton.GetComponent<Image>();
            Image.sprite = sprite;

            DisplaySetting.SetActive(false);
        }
        else if (state == SettingsState.Help)
        {
            sprite = Resources.Load<Sprite>("ヘルプ(消灯)");
            Image = HelpButton.GetComponent<Image>();
            Image.sprite = sprite;

            HelpSetting.SetActive(false);
        }
    }

     /*
     * changeSettings関数
     * [1] SettingsStateの状態によって点灯テクスチャに変更する
     * [2] 点灯テクスチャに変更された設定タブのUIを表示する
     */
    private void ChangeSettings()
    {
        switch (state)
        {
            case SettingsState.Volume:

                sprite = Resources.Load<Sprite>("音量(点灯)");
                Image = VolumeButton.GetComponent<Image>();
                Image.sprite = sprite;

                VolumeSetting.SetActive(true);

                break;
            case SettingsState.Brightness:

                sprite = Resources.Load<Sprite>("輝度(点灯)");
                Image = BrightnessButton.GetComponent<Image>();
                Image.sprite = sprite;

                BrightnessSetting.SetActive(true);

                break;
            case SettingsState.Display:

                sprite = Resources.Load<Sprite>("表示(点灯)");
                Image = DisplayButton.GetComponent<Image>();
                Image.sprite = sprite;

                DisplaySetting.SetActive(true);

                break;
            case SettingsState.Help:

                sprite = Resources.Load<Sprite>("ヘルプ(点灯)");
                Image = HelpButton.GetComponent<Image>();
                Image.sprite = sprite;

                break;
            //何かあった場合には設定画面を閉じてリセットする
            default:

                state = SettingsState.Volume;
                SettingsBoard.SetActive(false);
                OpenSettingsButton.SetActive(true);

                HelpSetting.SetActive(true);

                break;

        }
    }

    
    //設定UIをボタンで開くための関数
    public void OnClickOpenButton()
    {
        if (SettingsBoard.activeInHierarchy == false)
        {
            state = SettingsState.Volume;
            ChangeSettings();

            OpenSettingsButton.SetActive(false);
            CloseSettingsButton.SetActive(true);
            PausePanel.SetActive(false);

            SettingsBoard.SetActive(true);
            VolumeSetting.SetActive(true);

            BrightnessSetting.SetActive(false);
            DisplaySetting.SetActive(false);
            HelpSetting.SetActive(false);
        }
    }

    //設定UIをボタンで閉じるための関数
    public void OnClickCloseButton()
    {
        if (SettingsBoard.activeInHierarchy == true)
        {
            OpenSettingsButton.SetActive(true);
            CloseSettingsButton.SetActive(false);
            PausePanel.SetActive(true);

            SettingsBoard.SetActive(false);

            VolumeSetting.SetActive(false);
            BrightnessSetting.SetActive(false);
            DisplaySetting.SetActive(false);
            HelpSetting.SetActive(false);

            RestoreState();
        }
    }

    //設定UIの音量タブを選択したときに音量設定用UIを表示するための関数
    public void OnClickVolumeButton()
    {
        RestoreState();

        state = SettingsState.Volume;

        if (state == SettingsState.Volume)
        {
            ChangeSettings();
        }
    }

    //設定UIの輝度タブを選択したときに輝度設定用UIを表示するための関数
    public void OnClickBrightnessButton()
    {
        RestoreState();

        state = SettingsState.Brightness;

        if (state == SettingsState.Brightness)
        {
            ChangeSettings();
        }
    }

    //設定UIの表示タブを選択したときに表示設定用UIを表示するための関数
    public void OnClickDisplayButton()
    {
        RestoreState();

        state = SettingsState.Display;

        if (state == SettingsState.Display)
        {
            ChangeSettings();
        }
    }

    //設定UIのヘルプタブを選択したときにヘルプ確認用UIを表示するための関数
    public void OnClickHelpButton()
    {
        RestoreState();

        state = SettingsState.Help;

        if (state == SettingsState.Help)
        {
            ChangeSettings();
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
