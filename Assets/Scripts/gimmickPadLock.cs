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
    [SerializeField] MeshRenderer mesh;
    [SerializeField] GameObject player;
    private readonly int needKeyNum = 4;
    private string flagName = "openFlag";

    [SerializeField] Vector3 addPos;
    private void Start()
    {
        changeTag();
    }

    override public void getedGimic()
    {
        if (this.gamedirector.getkeyNum == needKeyNum)
        {
            //プレイヤー操作不可能
            gamedirector.activeCharactor(false);

            //オブジェクトの見た目だけをけす
            this.mesh.enabled = false;

            //外れる音(se再生)

            //1秒dilay 

            //ドアを開けるアニメーション再生
            animator.SetBool(flagName, true);
            //ドア開閉初動SE
            //ドア開閉途中SE


            //プレイヤー前進
            for (int i = 0; i < 100; i++)
            {
                player.transform.position += new Vector3(addPos.x, addPos.y, addPos.z);
            }

            //フェードアウト演出

            //クリアUI表示
            uidirector.activeGameClear(true);
        }

    }
}