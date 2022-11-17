using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChange : MonoBehaviour
{
    [SerializeField]
    Transform target;
    Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = target.gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale=Vector3.one* target.position.y;
        renderer.material.color = Color.gray * target.position.y;
    }
}
