using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Knob : Ply_Singleton<Knob>, IDragHandler
{
    private RectTransform _rectTransform;
    
    public override void Awake()
    {
        base.Awake();
        _rectTransform = GetComponent<RectTransform>();
    }

    public float zoom = 0;

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 localPoint;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            _rectTransform.parent as RectTransform, 
            eventData.position, 
            eventData.pressEventCamera, 
            out localPoint);
        
        var yy = Mathf.Clamp(localPoint.y, -50, 50);
        zoom = (yy + 50) / 100;
        UI.instance.zoomKnob(zoom);
        _rectTransform.localPosition = new Vector3(_rectTransform.localPosition.x, yy, 0);
    }
}
