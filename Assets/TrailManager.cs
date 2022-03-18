using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailManager : MonoBehaviour
{
    public static TrailManager instance;

    public int length;
    public float trailSpeed;

    public GameObject spiderPrefab;

    [HideInInspector]
    public GameObject currentSpider;

    [HideInInspector]
    public Vector3 pos;

    [HideInInspector]
    public Quaternion rotation; 
    void Start()
    {
        instance = this; 
        pos = new Vector3(0,0,0);         
        rotation = Quaternion.Euler(0f, 0f, 90f);
        currentSpider = Instantiate(spiderPrefab, pos, rotation);
        
    }


    void Update()
    {
        
    }

    public void SpeedPlus()
    {
        if (trailSpeed < 800)
        {       
             trailSpeed += 30;                     
        }
    }
    public void SpeedMinus()
    {
        if (trailSpeed > 30)
        {
           
             trailSpeed -= 30;         
        }

    }

    public void LengthPlus()
    {
        if (length < 20)
        {
            length++;
            pos = currentSpider.transform.position;
            Destroy(currentSpider);
            currentSpider = Instantiate(spiderPrefab, pos, rotation);
            
            
        }
    }
    public void LengthMinus()
    {
        if (length > 3)
        {
            length--;
            pos = currentSpider.transform.position;
            Destroy(currentSpider);
            currentSpider = Instantiate(spiderPrefab, pos, rotation);
        }
    }
}
