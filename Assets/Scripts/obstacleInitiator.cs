using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleInitiator : MonoBehaviour
{
    [SerializeField] GameObject wood;
    [SerializeField] GameObject stone;
    [SerializeField] GameObject glass;

    private void Awake()
    {
        if (wood.transform.childCount > 0)
        {
            for (int i = 0; i < wood.transform.childCount; i++)
            {
                wood.transform.GetChild(i).GetComponent<obstacle>().color = new Color32(255, 185, 100, 255);
                wood.transform.GetChild(i).GetComponent<obstacle>().damageThreshhold = 4.0f;
            }
        }

        if (stone.transform.childCount > 0)
        {
            for (int i = 0; i < stone.transform.childCount; i++)
            {
                stone.transform.GetChild(i).GetComponent<obstacle>().color = new Color32(145, 145, 145, 255);
                stone.transform.GetChild(i).GetComponent<obstacle>().damageThreshhold = 6.0f;
            }
        }

        if (glass.transform.childCount > 0)
        {
            for (int i = 0; i < glass.transform.childCount; i++)
            {
                glass.transform.GetChild(i).GetComponent<obstacle>().color = new Color32(187, 255, 251, 255);
                glass.transform.GetChild(i).GetComponent<obstacle>().damageThreshhold = 2.0f;
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

}
