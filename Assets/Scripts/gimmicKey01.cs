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
    public override void getedGimic()
    {
        //getGameMaster(gamedirector);
        //getUIComponent(UIdirector);

        gamedirector.addKeyNum();
        //取得したオブジェクトの処理
        UIdirector.dispkeyGetItems(gamedirector.getkeyNum);
        Destroy(this.gameObject);
    }
}