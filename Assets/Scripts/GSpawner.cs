using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] enemyPrefabs;

    bool control;
    void Bekle()
    {
        control=true;
    }
    void Start()
    {
        float sayi = Random.Range(4.5f,5.7f);
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
            int randEnemy = Random.Range(0, spawnPoints.Length);
            int randspawnPoints = Random.Range(0, spawnPoints.Length);
            Instantiate(enemyPrefabs[randEnemy],
             spawnPoints[randspawnPoints].position, transform.rotation);

        }
    }
}
