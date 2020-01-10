using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public ParticleSystem collectEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        if (controller != null)
        {
            if(controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                ParticleSystem effectObject = Instantiate(collectEffect, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
            
        }
    }
}
