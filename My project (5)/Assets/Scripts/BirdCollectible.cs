using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCollectible : MonoBehaviour
{
    public AudioClip birdClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {

            controller.ChangeBirds(1);
            Destroy(gameObject);

            controller.PlaySound(birdClip);

        }

    }
}
