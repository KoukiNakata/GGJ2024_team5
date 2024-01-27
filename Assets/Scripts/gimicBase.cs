using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface Igimic
{
    /// <summary>
    /// そのギミックの処理
    /// </summary>
    public void getGimic();
}

/// <summary>
/// ギミックのベースクラス(Igimicインタフェースを継承する) 
/// </summary>
public class gimicBase : MonoBehaviour, Igimic
{
    public void getUIComponent()
    {
        //UIコンポーネントを取得
    }

    public void getAudioComponent()
    {
        //音コンポーネントを取得
    }

    public void getGameMaster()
    {
        //マスタークラスの取得
    }

    virtual public void getGimic()
    {
        //ギミックの処理
    }
}

//UIの変更
//音の発生
//フラグ管理
//その他処理
//マスタークラスの取得