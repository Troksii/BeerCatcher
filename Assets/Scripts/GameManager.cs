using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{

    public GameObject Koskenkorva;
    public GameObject Lager;
    public GameObject LongDrink;
    public GameObject Joint;
    public float maxX;
    public float maxY;
    public float minY;
    public Transform spawnPoint;
    public Transform spawnPoint2;
    public float KoskenkorvaSpawnRate;
    public float LagerSpawnRate;
    public float LongDrinkSpawnRate;
    public float JointSpawnRate;

    public bool gameStarted = false;

    public GameObject tapText;
  
    // Start is called before the first frame update
    void Start()
    {
  

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !gameStarted)
        {
            StartSpawning();

            gameStarted = true;

            tapText.SetActive(false);
        }
    }

    private void StartSpawning()
    {
        StartCoroutine(StartSpawningKoskenkorva());
        StartCoroutine(StartSpawningLager());
        StartCoroutine(StartSpawningLongDrink());
        StartCoroutine(StartSpawningJoint());
    }
      

    IEnumerator StartSpawningKoskenkorva()
    {
    while(true)
    {
        yield return new WaitForSeconds(KoskenkorvaSpawnRate);
        SpawnKoskenkorva();
    }
    }
    
    IEnumerator StartSpawningLager()
    {
    while(true)
    {
        yield return new WaitForSeconds(LagerSpawnRate);
        SpawnLager();
    }
    }

    IEnumerator StartSpawningLongDrink()
    {
    while(true)
    {
        yield return new WaitForSeconds(LongDrinkSpawnRate);
        SpawnLongDrink();
    }
    }

    IEnumerator StartSpawningJoint()
    {
    while(true)
    {
        yield return new WaitForSeconds(JointSpawnRate);
        SpawnJoint();
    }
    }

    private void SpawnKoskenkorva()
    {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range (-maxX, maxX);

        Instantiate(Koskenkorva,spawnPos, Quaternion.identity);

    }

    private void SpawnLager()
    {
        Vector3 spawnPos = spawnPoint2.position;

        spawnPos.x = Random.Range (-maxX, maxX);

        Instantiate(Lager,spawnPos, Quaternion.identity);
        
    }

     private void SpawnLongDrink()
    {
        Vector3 spawnPos = spawnPoint2.position;

        spawnPos.x = Random.Range (-maxX, maxX);

        spawnPos.y = Random.Range (maxY, minY);

        Instantiate(LongDrink,spawnPos, Quaternion.identity);

    }

    private void SpawnJoint()
    {
        Vector3 spawnPos = spawnPoint.position;

        spawnPos.x = Random.Range (-maxX, maxX);

        spawnPos.y = Random.Range (maxY, minY);

        Instantiate(Joint,spawnPos, Quaternion.identity);

    }

  public void increaseSpawnrate()
    {
        KoskenkorvaSpawnRate = KoskenkorvaSpawnRate - 0.2F;
        LagerSpawnRate = LagerSpawnRate - 0.1F;
    }

}
