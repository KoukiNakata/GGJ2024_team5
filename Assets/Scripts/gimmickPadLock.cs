using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 最後のカギのギミック処理
/// </summary>
public class gimmickPadLock : gimicBase, Igimic
{
    [SerializeField] Gamedirector gamedirector;
    [SerializeField] Sounddiretctor sounddiretctor;
    [SerializeField] UIdirector uidirector;
    [SerializeField] Animator animator;
    //[SerializeField] MeshRenderer mesh;
    [SerializeField] GameObject player;
    private readonly int needKeyNum = 4;
    private string flagName = "openFlag";
    private string methodName = "gameClear";

    [SerializeField] Vector3 addPos;
    private void Start()
    {
        changeTag();
    }

    override public void getedGimic()
    {
        StartCoroutine(methodName);
    }

    IEnumerator gameClear()
    {
        // if (this.gamedirector.getkeyNum == needKeyNum)
        {
            //プレイヤー操作不可能
            gamedirector.activeCharactor(false);

            //オブジェクトの見た目だけをけす
            //this.mesh.enabled = false;

            //カギを開ける音(se再生)

            //1秒dilay 
            yield return new WaitForSeconds(1f);

            //ドアを開けるアニメーション再生
            animator.SetBool(flagName, true);
            //ドア開閉初動SE
            //ドア開閉途中SE

            yield return new WaitForSeconds(4);

            //ヴァーチャルカメラに変更

            //フェードアウト演出
            uidirector.fadeoutDirection();

            //ディレイ 1.5s フェードアウト演出時間
            yield return new WaitForSeconds(2.5f);

            //クリアUI表示
            uidirector.activeGameClear(true);
            uidirector.activeTitleButton_GameClear(true);
        }
        // else
        {
            //扉にカギがかかっている
            //テキスト表示
            //「ガチャガチャ」se再生
        }
    }
}