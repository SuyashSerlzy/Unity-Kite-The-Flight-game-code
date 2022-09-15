using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chargeuraa : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);   
    }
    void OnTriggerEnter()
    {
        Destroy(gameObject);
        print("Hit");
    }
}
