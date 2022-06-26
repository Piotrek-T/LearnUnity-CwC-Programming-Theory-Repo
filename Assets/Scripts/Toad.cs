using UnityEngine;

public class Toad : Animal
{
    private Rigidbody rb;

    private SpawnAnimal m_Animal;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        m_Animal = GameObject.Find("SpawnAnimals").GetComponent<SpawnAnimal>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(rb);
        if (transform.position.x < -workingRange || transform.position.x > workingRange ||
            transform.position.z < -workingRange || transform.position.z > workingRange)
        {
            Destroy(gameObject);
            m_Animal.LostAnimal();
        }
    }
}
