using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum keyName
{
    step_1,
    step_2,
    step_3,
    step_4
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
    public int getkeyNum = 0;

    /// <summary>
    /// ゲームスタート時の処理
    /// </summary>
    public void gameStart()
    {
        //セリフの再生

        //キャラクター操作可能
        activeCharactor();
    }

    public void gameClear()
    {
        UIdirector.activeGameClear(true);
        UIdirector.activeTitleButton_GameClear(true);
    }

    /// <summary>
    /// ゲームオーバー時の処理
    /// </summary>
    public void gameOver()
    {
        //ゲームオーバー時演出
        UIdirector.activeGameOver(true);
        UIdirector.activeRetryButton(true);
        UIdirector.activeTitleButton_GameOver(true);
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

    /// <summary>
    /// keyを取得した時に増やす
    /// </summary>
    public void addKeyNum()
    {
        getkeyNum = +1;
        awakeEvent(getkeyNum);
    }

    /// <summary>
    /// 取得数に応じたイベントの起動
    /// </summary>
    /// <param name="num"></param>
    private void awakeEvent(int num)
    {
        switch (num)
        {
            case 0:

                break;

            case 1:
                //敵が出現する
                break;

            case 2:
                //電気が消える
                break;

            case 3:
                //敵にスポットライトが当たる
                break;

            case 4:
                //UI変更(未定)
                break;
        }
    }

    /// <summary>
    /// keyを一個取得した時のイベント
    /// </summary>
    private void event1()
    {

    }

}