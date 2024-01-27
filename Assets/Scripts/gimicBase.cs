using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface Igimic
{
    /// <summary>
    /// そのギミックの処理
    /// </summary>
    public void getedGimic();
}

/// <summary>
/// ギミックのベースクラス(Igimicインタフェースを継承する) 
/// </summary>
public class gimicBase : MonoBehaviour, Igimic
{
    /*
    protected  UIdirector uIdirector;
    protected Sounddiretctor sounddiretctor;
    protected Gamedirector gamedirector;
    */

    private string UIobjName = "";
    //private string Ausdio

    private string tagName = "keyItem";

    protected void changeTag()
    {
        this.tag = tagName;
    }

    protected void getUIComponent(UIdirector uIdirector)
    {
        //UIコンポーネントを取得
        //uIdirector =gameObject.find GetComponent<UIdirector>();
    }

    protected void getAudioComponent(Sounddiretctor sounddiretctor)
    {
        //音コンポーネントを取得
        sounddiretctor = GetComponent<Sounddiretctor>();
    }

    protected void getGameMaster(Gamedirector gamedirector)
    {
        //マスタークラスの取得
        //gamedirector = GetComponent<Gamedirector>();
        gamedirector = new Gamedirector();
    }

    virtual public void getedGimic()
    {
        //ギミックの処理
    }
}

//UIの変更
//音の発生
//フラグ管理
//その他処理
//マスタークラスの取得