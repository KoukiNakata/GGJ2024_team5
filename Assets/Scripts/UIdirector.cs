using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using TMPro;
using UnityEngine.UIElements;
using Unity.VisualScripting;

/// <summary>
/// UIの挙動を管理するクラス
/// </summary>
public class UIdirector : MonoBehaviour
{
    [SerializeField] GameObject obj_gameOver;
    [SerializeField] GameObject[] obj_keyItems;
    [SerializeField] GameObject obj_retryButton;
    [SerializeField] GameObject obj_titleButtonGameClear;
    [SerializeField] GameObject obj_gameClear;
    [SerializeField] GameObject obj_titleButtonGameOver;
    [SerializeField] GameObject fadeoutImage;

    [SerializeField] Image panicImage;
    [SerializeField] Image[] keyItems;
    [SerializeField] fadeDirection fadeDirection;

    // Start is called before the first frame update
    void Start()
    {
        initialize();
    }

    /// <summary>
    /// UIの表示初期化
    /// </summary>
    public void initialize()
    {
        for (int i = 0; i < obj_keyItems.Length; i++)
        {
            obj_keyItems[i].SetActive(false);
        }
        activeGameOver(false);
        activeGameClear(false);
        activeRetryButton(false);
        activeTitleButton_GameClear(false);
        activeTitleButton_GameOver(false);
        activeFadeutImage(false);
    }

    /// <summary>
    /// ゲームオーバー表示変更
    /// </summary>
    public void activeGameOver(bool active)
    {
        obj_gameOver.SetActive(active);
    }

    /// <summary>
    /// リトライボタン表示変更
    /// </summary>
    public void activeRetryButton(bool active)
    {
        obj_retryButton.SetActive(active);
    }

    /// <summary>
    /// ゲームクリア表示変更
    /// </summary>
    public void activeGameClear(bool active)
    {
        obj_gameClear.SetActive(active);
    }

    /// <summary>
    /// ゲームクリア時タイトルボタン表示変更
    /// </summary>
    public void activeTitleButton_GameClear(bool active)
    {
        obj_titleButtonGameClear.SetActive(active);
    }

    /// <summary>
    /// ゲームオーバー時タイトルボタン表示変更
    /// </summary>
    public void activeTitleButton_GameOver(bool active)
    {
        obj_titleButtonGameOver.SetActive(active);
    }

    /// <summary>
    /// アイテム取得時UI更新
    /// </summary>
    public void displyKeyGetItems(int num)
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

    private void activeFadeutImage(bool active)
    {
        fadeoutImage.SetActive(active);
    }

    /// <summary>
    ///フェードアウト演出 
    /// </summary>
    public void fadeoutDirection()
    {
        activeFadeutImage(true);
        fadeDirection.fadeoutDirection();
    }
}