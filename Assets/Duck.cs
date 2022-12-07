using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    private bool Hit = true;
    [Range(0, 10)] public float Speed = 0;
    private Rigidbody Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody.velocity = Vector3.up*Speed;
        if (gameObject.transform.position.y > 10)
        {
            Hit=false;
            gameObject.SetActive(false);
        }
    }
    public void SetSpeed(float var)
    {
        Speed = var;
    }
    private void OnEnable()
    {
        Hit = true;
    }
    private void OnDisable()
    {
        if(Hit==true)
        ScoreManager.instance.IncreaseScore();
    }
}
