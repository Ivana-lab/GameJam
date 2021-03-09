using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{

    public GameObject explosion;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BoxObject box = collision.gameObject.AddComponent<BoxObject>();
        if (box != null)
        {
            explosion.SetActive(true);
            Invoke("animationExplosion", 1f);
        }
    }

    public void animationExplosion()
    {
        explosion.SetActive(false);
        gameObject.SetActive(false);
    }

}
