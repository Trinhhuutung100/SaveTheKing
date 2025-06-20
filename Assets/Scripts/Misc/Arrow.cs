using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Arrow : Ply_Singleton<Arrow>
{

    public override void Awake()
    {
        base.Awake();
    }

    public GameObject target;
    public GameObject[] targets;

    bool off = false;

    int count = 0;

    public void setPosition() {
        var wCam = UI.instance.cam;
        var uiCam = UI.instance.uiCam;
        var pos = wCam.WorldToScreenPoint(target.transform.position);
        var uiPos = uiCam.ScreenToWorldPoint(pos);
        uiPos.z = 0;
        transform.position = uiPos;
    }

    // Update is called once per frame
    void Update()
    {
        if(target) {
            setPosition();
            // target.GetComponent<Screw>().setOutline();
        }
    }
}
