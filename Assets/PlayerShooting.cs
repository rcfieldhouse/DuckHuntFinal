using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Mouse0) == true)
        {

            Debug.Log(Input.mousePosition.x/45.0f);
            Debug.Log(Input.mousePosition.y / 45.0f);
            Instantiate(prefab, new Vector3((Input.mousePosition.x / 55.0f)-17.0f, (Input.mousePosition.y / 55.0f)-7.0f,0.0f),Quaternion.identity);
        }
    }
}
