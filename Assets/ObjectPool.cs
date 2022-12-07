using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public List<GameObject> Ducks;
    private bool Duckfound = false;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <transform.childCount; i++)
        {
           Ducks.Add(transform.GetChild(i).gameObject);
        }
    }

    public GameObject GetDisabledDuck()
    {
        //find a duck that is not active
        Duckfound = false;
        for (int i = 0; i <Ducks.Count; i++)
        {
            if (Ducks[i].activeInHierarchy == false)
            {          
                if (Duckfound == false)
                {
                   
                    Duckfound = true;

                    return Ducks[i];                 
                }             
            }
        }
                         
        if (Duckfound == false)
        {
           
            return Ducks[0];
        }

        Duckfound = false;
        return null;

      
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
