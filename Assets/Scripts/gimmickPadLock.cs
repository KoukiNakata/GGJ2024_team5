using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gimmickPadLock : gimicBase, Igimic
{
    [SerializeField] Gamedirector gamedirector;
    private readonly int needKeyNum = 4;
    private void Start()
    {
        changeTag();
    }

    override public void getedGimic()
    {
        if (this.gamedirector.getkeyNum == needKeyNum)
        {
            Destroy(this.gameObject);
            //外れる音

            //1秒dilay 

            //ドアを開けるアニメーション再生
            //ドア開閉SE


            //プレイヤー前進

            //クリアUI表示
        }

    }
}