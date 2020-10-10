using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public AudioClip deathSound;
    public AudioSource audioS;

    private void OnCollisionEnter(Collision collision)
    {
        AudioSource.PlayClipAtPoint(deathSound, transform.position);
        
        Destroy(gameObject);
    }
}
