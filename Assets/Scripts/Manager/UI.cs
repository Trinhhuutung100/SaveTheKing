using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Luna.Unity;
using DG.Tweening;

public class UI : Ply_Singleton<UI>
{

    public override void Awake()
    {
        base.Awake();
    }

    public Camera cam;
    public Camera uiCam;
    public float scale = 1080/1920;

    float vH = 0.1218198f;
    public float vFov = 55;
    public float vWidth = 334;
    public float vScale = 0.72f;

    float hH = 0.1330172f;
    public float hFov = 25;
    public float hHeight = 344;
    public float hScale = 0.72f;

    public float maxDistance = 10;

    float distance = 0;
    float scrollSpeed = 1;

    public GameObject endCard;
    public GameObject arrow;

    bool firstFrame = true;

    Vector3 defaultCamPos;


    public bool isStore;

    public void OpenStore() { 
        LifeCycle.GameEnded();
        Playable.InstallFullGame();
    }

    private void Start() {
        defaultCamPos = cam.transform.position;
        InputManager.instance.bindingScroll += zoomIn;
    }

    public void zoomIn(float d) {
        distance = Mathf.Clamp(distance + d, 0, maxDistance);
        cam.transform.position = defaultCamPos + cam.transform.forward * distance * scrollSpeed;
    }
    public void zoomKnob(float d) {
        distance = maxDistance * d;
        cam.transform.position = defaultCamPos + cam.transform.forward * distance;
    }

    public void onEndCard() {
        SoundManager.instance.playSound(SoundType.Lose);
        isStore = true;
        endCard.SetActive(true);
    }

    public void onOneHoleRemain(bool isShow) {
    }

    public void resize() {
        var sc = (float)Screen.width / (float)Screen.height;
        
        if(sc != scale) {
                 
            if(sc > 1) {
                cam.fieldOfView = 25;
            } else {
                cam.fieldOfView = 55;
            }
            Vector3 bottomLeft = cam.ScreenToWorldPoint(new Vector3(0, 0, cam.nearClipPlane));
            Vector3 bottomRight = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0, cam.nearClipPlane));
            Vector3 topLeft = cam.ScreenToWorldPoint(new Vector3(0, Screen.height, cam.nearClipPlane));
            Vector3 topRight = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, cam.nearClipPlane));
            
            var time = 0.1f;
            if(firstFrame) {
                firstFrame = false;
                time = 0f;
            }
            DOVirtual.DelayedCall(time, () => {     

                float width = Vector3.Distance(bottomLeft, bottomRight);
                float height = Vector3.Distance(bottomLeft, topLeft);
                
                float fov = 0;
                scale = sc;
                if(sc > 1) {
                    arrow.transform.localScale = Vector3.one * 0.6f;
                    fov = hFov * hH / height;
                } else {
                    arrow.transform.localScale = Vector3.one;
                    fov = vFov * vH / width;
                }
                cam.fieldOfView = fov;
            });
        }
    }

    // Update is called once per frame
    void Update()
    {
        resize();
        if(isStore) {
            if(Input.GetMouseButtonDown(0)) {
                OpenStore();
            }
        }
    }
}
