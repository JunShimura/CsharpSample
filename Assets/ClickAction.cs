using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody))]
public class ClickAction : MonoBehaviour, IPointerClickHandler,IPointerDownHandler, IPointerUpHandler
{

    Rigidbody rigidBody;
    public Vector3 force = new Vector3(0, 10, 0);
    public ForceMode forceMode = ForceMode.VelocityChange;

    // Use this for initialization
    void Start()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Vector3 vTemp = new Vector3(1, 2, 3);
        rigidBody.AddForce(force, forceMode);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        transform.Rotate(0, 2.5f, 0);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        transform.Rotate(-10.0f, 0,0);
    }
}
class CL
{
    public float x; public float y;
    public CL(float x, float y)
    {
        this.x= x; this.y = y;    
    }
};

