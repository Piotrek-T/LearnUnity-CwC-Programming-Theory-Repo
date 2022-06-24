using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Toad : Animal
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        move(rb);
    }

    protected void move(Rigidbody rigBody)
    {
        rigBody.AddForce(0.5f,15f,0, ForceMode.Force);
        transform.Rotate(0, Random.Range(-90, 90), 0);
    }
}
