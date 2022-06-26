using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public abstract class Animal : MonoBehaviour
{
    [SerializeField]
    protected float workingRange;

    protected void Move(float speed)
    {
        transform.Translate(Vector3.forward * (speed * Time.deltaTime));
        transform.Rotate(0,(float)Random.Range(-90, 90), 0);
    }
    
    protected void Move(Rigidbody rigBody)
    {
        StartCoroutine(ToadJump(rigBody));
    }
    
    IEnumerator ToadJump(Rigidbody rigBody)
    {
        if (rigBody.transform.position.y <= 0.5)
        {
            rigBody.transform.Rotate(0, Random.Range(-90, 90), 0);
            yield return new WaitForSeconds(2);
            rigBody.velocity = Vector3.zero;
            rigBody.AddRelativeForce(5f,5f,0, ForceMode.Impulse);
        }
    }
}
