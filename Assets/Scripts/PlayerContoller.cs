using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    private Rigidbody playerRb;
    
    [SerializeField]
    private float speed = 0.3f;
    
    [SerializeField]
    private float playerRange = 48;

    [SerializeField] 
    private TMP_Text scoreText;
    private int score;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ContrainsPlayerPosition();
        scoreText.text = "Score: " + score;
    }
    
    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        // playerRb.AddForce(Vector3.forward * speed * verticalInput);
        // playerRb.AddForce(Vector3.right * speed * horizontalInput);
        transform.Translate(Vector3.forward * (speed * verticalInput));
        transform.Rotate(0f, (12 * speed * horizontalInput), 0f);
        
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y <= 1)
        {
            playerRb.AddForce(Vector3.up * 8, ForceMode.Impulse);
        }
    }

    void ContrainsPlayerPosition()
    {
        if (transform.position.z < -playerRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -playerRange);
        }

        if (transform.position.z > playerRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, playerRange);
        }
        
        if (transform.position.x < -playerRange)
        {
            transform.position = new Vector3(-playerRange, transform.position.y, transform.position.z);
        }
        
        if (transform.position.x > playerRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, playerRange);
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Animal"))
        {
            if (other.gameObject.name == "Toad(Clone)")
            {
                score += 20;
            }
            
            if (other.gameObject.name == "Mouse(Clone)")
            {
                score += 40;
            }

            Destroy(other.gameObject);
        }
    }
}
