using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //varibles
    private float speed = 5.0f;
    public float horizontalInput;
    public float forwardInput;
    public ParticleSystem explosionParticle;
    public GameObject projectilePrefab;
    // Start is called before the first fram update
    void Start()
    {

    }

    // Update is called once per fram
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            // Shoot Football
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        // move the player forward
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // moves player forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // moves player sideways
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            explosionParticle.Play();
        }
    }
}
