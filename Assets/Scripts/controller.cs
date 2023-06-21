using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public static controller instance;
    [SerializeField]
    Camera cam;

    public Vector2 MousePos
    {
        get { return cam.ScreenToWorldPoint(Input.mousePosition); }
    }

    // Start is called before the first frame update
    void Awake()
    {
        cam = Camera.main;
        instance = this;
    }

    // Update is called once per frame
    void OnDestroy()
    {
        instance = null;
    }
}
