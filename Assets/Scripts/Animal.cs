using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    // Start is called before the first frame update
    public void move(float speed)
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        transform.Rotate(0,(float)Random.Range(-90, 90), 0);
    }

}
