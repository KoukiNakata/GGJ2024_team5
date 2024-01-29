using System.Collections;
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
    [SerializeField] GameObject mainCam, cam1, cam2;
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
        if (this.gamedirector.getkeyNum == needKeyNum)
        {
            //プレイヤー操作不可能
            gamedirector.activeCharactor(false);

            mainCam.SetActive(false);

            cam1.SetActive(true);

            //オブジェクトの見た目だけをけす
            //this.mesh.enabled = false;

            //カギを開ける音(未実装)

            //1秒dilay 
            yield return new WaitForSeconds(2.5f);

            //ドアを開けるアニメーション再生
            animator.SetBool(flagName, true);

            //ドア開閉初動SE(未実装)
            //ドア開閉途中SE(未実装)

            yield return new WaitForSeconds(4);

            //ヴァーチャルカメラに変更
            cam1.SetActive(false);
            cam2.SetActive(true);

            yield return new WaitForSeconds(3);

            //フェードアウト演出
            uidirector.fadeoutDirection();

            //ディレイ 1.5s フェードアウト演出時間
            yield return new WaitForSeconds(2.5f);

            //クリアUI表示
            uidirector.activeGameClear(true);
            uidirector.activeTitleButton_GameClear(true);
        }
        else
        {
            //扉にカギがかかっているテキスト表示(未実装)
            //「ガチャガチャ」se再生(未実装)
        }
    }
}