using UnityEngine;
using UnityEngine.UI;

public class Hints : MonoBehaviour
{
    public Button endHintButton;
    public GameObject hintPanel;

    private void Awake()
    {
        endHintButton.onClick.AddListener(CloseHintPanel);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMove pl = collision.gameObject.GetComponent<PlayerMove>();
        if (pl != null)
        {
            gameObject.SetActive(false);
            hintPanel.SetActive(true);
        }
    }

    public void CloseHintPanel()
    {
        hintPanel.SetActive(false);
    }

}
