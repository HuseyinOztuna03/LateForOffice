using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSpawner : MonoBehaviour
{
    public Transform[] spawnOPoints;
    public GameObject[] OPrefabs;

    bool control;
    void Bekle()
    {
        control=true;
    }
    void Start()
    {
        float sayi = Random.Range(0.65f,1f);
        Invoke("Bekle" , sayi);
        Invoke("deneme" , sayi);
        CancelInvoke("Start");
    }
    void deneme()
    {
        
        InvokeRepeating("Start" , 0 , 2);
        
    }
    void Update()
    {
       
        if(control==true)
        {
            control=false;
            int randOPrefabs = Random.Range(0, spawnOPoints.Length);
            int randspawnOPoints = Random.Range(0, spawnOPoints.Length);
            Instantiate(OPrefabs[randOPrefabs],
            spawnOPoints[randspawnOPoints].position, transform.rotation);
        }
    }
}
