using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimal : MonoBehaviour
{
    [SerializeField] protected GameObject[] spawnPrefab;
    
    private int m_NumberOfAnimals = 0;

    [SerializeField]
    protected int numberOfAnimals;

    [SerializeField]
    protected Transform parent;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AnimalSpawner());
    }
    
    private void Spawn(Vector3 spawnPosition)
    {
        int i = Random.Range(0, spawnPrefab.Length);
        GameObject instance = Instantiate(spawnPrefab[i],parent);
        instance.transform.position = spawnPosition;
    }

    private IEnumerator AnimalSpawner()
    {
        
        while(m_NumberOfAnimals<numberOfAnimals)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-8, 8), 0.4f, Random.Range(-8, 8));
            Spawn(spawnPosition);
            m_NumberOfAnimals += 1;
            yield return new WaitForSeconds(3);
        }
    }

    public void LostAnimal()
    { 
        m_NumberOfAnimals -= 1;
        StartCoroutine(AnimalSpawner());
    }
}
