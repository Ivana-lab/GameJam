using UnityEngine;
using UnityEngine.UI;

public class MaryScript : MonoBehaviour
{
    public Button endHintButton;
    public GameObject hintPanel;

    public GameObject effect;

    public bool talkDone = false;

    private void Awake()
    {
        endHintButton.onClick.AddListener(CloseHintPanel);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMove pl = collision.gameObject.GetComponent<PlayerMove>();
        if (pl != null && !talkDone)
        {
            hintPanel.SetActive(true);
            talkDone = true;
        }
    }

    public void CloseHintPanel()
    {
        effect.SetActive(false);
        hintPanel.SetActive(false);
    }

}
