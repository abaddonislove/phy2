using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleInitiator : MonoBehaviour
{
    [SerializeField] GameObject wood;
    [SerializeField] GameObject stone;
    [SerializeField] GameObject glass;

    Color32 woodColor = new Color32(255, 185, 100, 255);
    Color32 stoneColor = new Color32(145, 145, 145, 255);
    Color32 glassColor = new Color32(187, 255, 251, 255);

    private void Awake()
    {
        setProperties(wood, woodColor);
        setProperties(stone, stoneColor);
        setProperties(glass, glassColor);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void setProperties(GameObject group, Color32 color)
    {
        if (group.transform.childCount > 0)
        {
            for (int i = 0; i < group.transform.childCount; i++)
            {
                group.transform.GetChild(i).GetComponent<obstacle>().color = color;
                group.transform.GetChild(i).GetComponent<obstacle>().damageThreshhold = 2.0f;
            }
        }
    }
}
