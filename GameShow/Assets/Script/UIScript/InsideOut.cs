using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InsideOut : MonoBehaviour
{
    [Header("表裏反転UI")]
    [SerializeField] private GameObject  InsideOutUI;

    private Image Image;

    private Sprite sprite;

    public enum InsideOutUIState
    {
        Inside = 0, Outside = 1
    }

    InsideOutUIState state;

    //public bool ScoreProp
    //{
    //    get { return InsideOutUIState; }
    //    private set { this.score = value; }
    //}

    // Start is called before the first frame update
    void Start()
    {
        state = InsideOutUIState.Inside;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
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
}
