using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsideOut : MonoBehaviour
{
    [Header("表裏反転UI")]
    [SerializeField] private GameObject InsideOutUI;
    [SerializeField] private GameObject Player;

    //UIImage変更用変数
    private Image Image;
    private Sprite sprite;

    //PlayerScriptから表裏反転の状態を受け取るための変数
    private PlayerScript PlayerScript;
    private int InsideOutNumber;

    public enum InsideOutUIState
    {
        Inside = 0, Outside = 1
    }

    InsideOutUIState state;

    // Start is called before the first frame update
    void Start()
    {
        state = InsideOutUIState.Inside;
    }

    // Update is called once per frame
    void Update()
    {
        //常に表裏反転の状態を取得し、反映
        PlayerScript = Player.GetComponent<PlayerScript>();
        InsideOutNumber = PlayerScript.GetInsideOutNumber;

        if (InsideOutNumber == 0)
        {
            state = InsideOutUIState.Inside;
        }
        else
        {
            state = InsideOutUIState.Outside;
        }

        if (state == InsideOutUIState.Inside)
        {
            sprite = Resources.Load<Sprite>("表UI");
            Image = InsideOutUI.GetComponent<Image>();
            Image.sprite = sprite;

            state = InsideOutUIState.Outside;
        }
        else if (state == InsideOutUIState.Outside)
        {
            sprite = Resources.Load<Sprite>("裏UI");
            Image = InsideOutUI.GetComponent<Image>();
            Image.sprite = sprite;

            state = InsideOutUIState.Inside;
        }
    }
}
