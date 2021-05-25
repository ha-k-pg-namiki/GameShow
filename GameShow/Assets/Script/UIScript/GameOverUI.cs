using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    [Header("GameOverUI")]
    [SerializeField] private GameObject GameOverUIImage;

    //UIImage変更用変数
    private Image Image;
    private Sprite sprite;

    //
    private int ChangeNumber;

    private IEnumerator ChangeTexCor()
    {
        for (int i = 0; i > 100; ++i)
        {
            ChangeNumber = Random.Range(1, 100);

            if (ChangeNumber % 2 == 1)
            {
                sprite = Resources.Load<Sprite>("がめお");
                Image = GameOverUIImage.GetComponent<Image>();
                Image.sprite = sprite;
            }
            else if (ChangeNumber % 2 == 0)
            {
                sprite = Resources.Load<Sprite>("がめおくろ");
                Image = GameOverUIImage.GetComponent<Image>();
                Image.sprite = sprite;
            }

            yield return new WaitForSeconds(1.0f);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ChangeNumber = Random.Range(1, 100);

        if (ChangeNumber % 2 == 1 || ChangeNumber % 4 == 0 || ChangeNumber % 3 == 2 || ChangeNumber % 5 == 3 || ChangeNumber % 7 == 6)
        {
            sprite = Resources.Load<Sprite>("がめお");
            Image = GameOverUIImage.GetComponent<Image>();
            Image.sprite = sprite;
        }
        else
        {
            sprite = Resources.Load<Sprite>("がめおくろ");
            Image = GameOverUIImage.GetComponent<Image>();
            Image.sprite = sprite;
        }
    }
}
