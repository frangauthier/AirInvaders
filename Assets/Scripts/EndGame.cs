using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public static int killCount = 0;

    [SerializeField] GameObject mainText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void endGame()
    {
        mainText.SetActive(true);
        mainText.GetComponent<Text>().text = string.Format("The End.\nYou killed {0} invaders", EndGame.killCount);
        Time.timeScale = 0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            endGame();
        }
    }
}
