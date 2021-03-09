using UnityEngine;
using UnityEngine.UI;

public class MaryScript : MonoBehaviour
{
    public Button endHintButton;
    public GameObject hintPanel;

    public GameObject effect;

    private void Awake()
    {
        endHintButton.onClick.AddListener(CloseHintPanel);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMove pl = collision.gameObject.GetComponent<PlayerMove>();
        if (pl != null)
        {
            hintPanel.SetActive(true);
        }
    }

    public void CloseHintPanel()
    {
        effect.SetActive(false);
        hintPanel.SetActive(false);
    }

}
