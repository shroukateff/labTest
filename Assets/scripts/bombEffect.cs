using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombEffect : MonoBehaviour
{
    [SerializeField] private ParticleSystem particles=default;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            particles.Play();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
