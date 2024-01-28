using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gimmicKey01 : gimicBase, Igimic
{
    [SerializeField] private UIdirector UIdirector;
    [SerializeField] private Sounddiretctor sounddiretctor;
    [SerializeField] private Gamedirector gamedirector;

    private void Start()
    {
        changeTag();
    }

    /// <summary>
    /// キーアイテム取得時の処理
    /// </summary>
    public override void getedGimic()
    {
        gamedirector.addKeyNum();
        UIdirector.displyKeyGetItems(gamedirector.getkeyNum);
        //SE再生
        Destroy(this.gameObject);
    }
}