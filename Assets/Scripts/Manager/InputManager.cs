using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class InputManager : Ply_Singleton<InputManager>
{

    public override void Awake() {
        base.Awake();
    }

    public float sensitivity = 2.0f; // Độ nhạy chuột

    public float mouseX;
    public float mouseY;

    public Quaternion yawRotation;

    public Quaternion pitchRotation;


    // public Quaternion originalRotation;


    public Action<InputManager> bindingMove;
    public Action<InputManager> bindingStart;
    public Action<float> bindingScroll;


    // Start is called before the first frame update
    void Start()
    {
    }



    void onTouchStart() {
        if(bindingStart != null) {
            bindingStart.Invoke(this);
        }
    }       

    void onTouchMove() {
        mouseX = Input.GetAxis("Mouse X") * sensitivity;
        mouseY = Input.GetAxis("Mouse Y") * sensitivity;
        
        yawRotation = Quaternion.AngleAxis(- mouseX, Vector3.up);
        pitchRotation = Quaternion.AngleAxis( mouseY, Vector3.left);
        if(bindingMove != null) {
            bindingMove.Invoke(this);
        }
    }

    void onScroll() {
        if(bindingScroll != null) {
            bindingScroll.Invoke(Input.mouseScrollDelta.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(UI.instance.isStore) {
            return;
        }
        if(Input.GetMouseButton(0)) {
            onTouchMove();
        }
        if(Input.GetMouseButtonDown(0)) {
            onTouchStart();
        }
        if(Input.mouseScrollDelta.y != 0) {
            onScroll();
        }
        if(Input.GetMouseButtonUp(0)) {
            // onTouchEnd();
        }
    }
}
