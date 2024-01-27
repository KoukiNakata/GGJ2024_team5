using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using TMPro;
using UnityEngine.UIElements;

/// <summary>
/// UIの挙動を管理するクラス
/// </summary>
public class UIdirector : MonoBehaviour
{
    [SerializeField] GameObject obj_gameOver;
    [SerializeField] GameObject[] obj_keyItems;
    [SerializeField] GameObject obj_retryButton;



    [SerializeField] TextMeshProUGUI tmp_gameOver;
    [SerializeField] Image panicImage;
    [SerializeField] Image[] keyItems;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void initialize()
    {
        obj_gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// ゲームオーバー表示
    /// </summary>
    public void activeGameOver()
    {
        obj_gameOver.SetActive(true);
    }

    /// <summary>
    /// リトライボタン表示
    /// </summary>
    public void activeRetryButton()
    {
        obj_retryButton.SetActive(true);
    }

    /// <summary>
    /// アイテム取得時UI更新
    /// </summary>
    public void dispkeyGetItems(int num)
    {
        for (int i = 0; i < obj_keyItems.Length; i++)
        {
            obj_keyItems[i].SetActive(false);
        }

        for (int i = 0; i < num; i++)
        {
            obj_keyItems[i].SetActive(true);
        }
    }

}
