using UnityEngine;

public class Mouse : Animal
{
    [SerializeField]
    private float speed;
    
    private SpawnAnimal m_Animal;
    
    // Start is called before the first frame update
    void Start()
    {
        m_Animal = GameObject.Find("SpawnAnimals").GetComponent<SpawnAnimal>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(speed);
        if (transform.position.x < -workingRange || transform.position.x > workingRange ||
            transform.position.z < -workingRange || transform.position.z > workingRange)
        {
            m_Animal.LostAnimal();
            Destroy(gameObject);
        }
    }
}
