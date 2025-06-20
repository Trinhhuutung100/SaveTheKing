using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;



public class LevelManager : Ply_Singleton<LevelManager>
{

    
    public override void Awake()
    {
        base.Awake();
    }  


    int countToStore = 0;

    int currentKey = 0;
    public int currentHoleMax = 3;

    Dictionary<int, int> colorCount = new Dictionary<int, int>();


    

    public void onTouchMove(InputManager input) {
        transform.rotation = input.yawRotation * input.pitchRotation * transform.rotation;
    }

    // Start is called before the first frame update
    void Start()
    {
        InputManager.instance.bindingMove += onTouchMove;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

