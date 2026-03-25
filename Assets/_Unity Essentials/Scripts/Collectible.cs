using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float rotationSpeed = 50.0f; // Set rotation speed for visual effect.

    public GameObject onCollectEffect; // Reference to collectible prefab for instantiation.

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotationSpeed, 0f, Space.World); // Rotate collectible for visual effect.
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(onCollectEffect, transform.position, transform.rotation); // Instantiate effect on collection.
            Destroy(gameObject); // Destroy collectible on collision with player.
        }
    }
}
