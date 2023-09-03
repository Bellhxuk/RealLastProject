using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckParticleCollide : MonoBehaviour
{
    public GameObject flame;
    private ParticleSystem ps;
    private int hp = 2000, dmg = 10;
    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        Debug.LogWarning("start");
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Fire"))
        {
            Debug.LogWarning("Particle collided with: " + other.name + hp);
            hp -= dmg;
            if (hp < 1)
            {
                flame.SetActive(false);

            }
        }
    }
}
