using UnityEngine;

public class dynamite : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMove pl = collision.gameObject.GetComponent<PlayerMove>();
        if (pl != null)
        {
            pl.setDynamite();
            gameObject.SetActive(false);
        }
    }
}
