using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDucks : MonoBehaviour
{
    public ObjectPool pool;
    [Range(0, 5)] public float SpawnRate = 0,speedOfDucks;
    public WaitForSeconds spawnTime=new WaitForSeconds(0.5f);
    // Start is called before the first frame update
    void Start()
    {
        spawnTime = new WaitForSeconds(SpawnRate);
      
       StartCoroutine(SpawnNewDuck());
    }

   public IEnumerator SpawnNewDuck()
    {
       
        yield return spawnTime;
        SpawnDuck();
        StartCoroutine(SpawnNewDuck());
    }
    private void SpawnDuck()
    {
        Debug.Log(pool.GetDisabledDuck().name);
        pool.GetDisabledDuck().transform.position = gameObject.transform.position;
        pool.GetDisabledDuck().GetComponent<Duck>().SetSpeed(speedOfDucks);
        pool.GetDisabledDuck().SetActive(true);
     
       
    }
  
}
