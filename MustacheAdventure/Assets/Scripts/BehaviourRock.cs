using UnityEngine;

public class BehaviourRock : MonoBehaviour
{
    public GameObject boom;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMove pl = collision.gameObject.GetComponent<PlayerMove>();
        if (pl != null)
        {
            if (pl.hasDynamite())
            {
                boom.SetActive(true);
                Invoke("endBoom", 2f);
                gameObject.SetActive(false);
            }
        }
    }

    public void endBoom() 
    {
        boom.SetActive(false);
    }

}
