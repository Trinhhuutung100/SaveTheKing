using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{


    void onTouchStart(InputManager input) {
        Ray ray = UI.instance.cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 20f)) {
            var layer = hit.collider.gameObject.layer;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        InputManager.instance.bindingStart += onTouchStart;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
