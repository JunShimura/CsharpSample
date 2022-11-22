using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody))]
public class ClickAction : MonoBehaviour, IPointerClickHandler
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
        vTemp = force;
        vTemp.x = -5;
        CL clA = new CL(1, 2);
        CL clB = new CL(3, 5);
        clB = clA;
        clB.x = -5;
        rigidBody.AddForce(force, forceMode);
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

