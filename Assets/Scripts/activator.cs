using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activator : MonoBehaviour
{
    [SerializeField]
    GameObject effectorField;
    //int effectorType;
    SurfaceEffector2D suEffector;
    AreaEffector2D arEffector;
    PointEffector2D poEffector;
    BuoyancyEffector2D buEffector;

    // Start is called before the first frame update
    void Start()
    {
        /*try
        {
            suEffector = effectorField.GetComponent<SurfaceEffector2D>();
        }
        catch { }

        try
        {
            arEffector = effectorField.GetComponent<AreaEffector2D>();
        }
        catch { }

        try
        {
            poEffector = effectorField.GetComponent<PointEffector2D>();
        }
        catch { }

        try
        {
            buEffector = effectorField.GetComponent<BuoyancyEffector2D>();
        }
        catch { }*/

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!effectorField.activeInHierarchy)
        {
            effectorField.SetActive(true);
        }
    }
}
