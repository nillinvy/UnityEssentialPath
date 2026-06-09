//using UnityEditor.UI;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public float turn = 5;
    public GameObject onCollectEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);
        transform.Rotate(0, turn*Time.deltaTime, 0, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
    }
}
