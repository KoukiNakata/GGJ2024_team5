using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum keyName
{

}

/// <summary>
/// ゲームマスタークラス
/// </summary>
public class Gamedirector : MonoBehaviour
{
    [SerializeField] SceneManagerClass sceneManagerClass;
    [SerializeField] charactorController charactorController;
    [SerializeField] UIdirector UIdirector;
    [SerializeField] Sounddiretctor sounddiretctor;

    public bool[] keyFlag = { false, false, false, false };

    /// <summary>
    /// ゲームスタート時の処理
    /// </summary>
    public void gameStart()
    {
        //セリフの再生

        //キャラクター操作可能
        activeCharactor();
    }

    /// <summary>
    /// ゲームオーバー時の処理
    /// </summary>
    public void gameOver()
    {
        //ゲームオーバー時演出
        //げーむおーばーUI表示
        UIdirector.activeGameOver();
        //リトライボタン表示
        UIdirector.activeRetryButton();
    }

    /// <summary>
    /// フラグの書き換え
    /// </summary>
    /// <param name="num"></param>
    public void activeflag(int num)
    {
        keyFlag[num] = true;
    }

    /// <summary>
    /// キャラクターのアクティブフラグ操作
    /// </summary>
    public void activeCharactor()
    {
        this.charactorController.activeFlag = !this.charactorController.activeFlag;
    }

}
