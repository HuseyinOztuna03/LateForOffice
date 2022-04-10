using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteelSpawner : MonoBehaviour
{
    public Transform[] spawnPointsST;
    public GameObject[] steelPrefabs;

    bool control;
    void Bekle()
    {
        control=true;
    }
    void Start()
    {
        float sayi = Random.Range(25f,45f);
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
            int randsteelPrefabs = Random.Range(0, spawnPointsST.Length);
            int randspawnPointsST = Random.Range(0, spawnPointsST.Length);
            Instantiate(steelPrefabs[randsteelPrefabs],
            spawnPointsST[randspawnPointsST].position, transform.rotation);

        }
    }
}
