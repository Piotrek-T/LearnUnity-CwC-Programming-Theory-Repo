using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : Animal
{
    [SerializeField]
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move(speed);
    }
}
