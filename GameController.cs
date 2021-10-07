using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public bool winGame;
    public bool loseGame;

    public GameObject victory;
    public GameObject defeat;

    public PlayerMoviment playerScript;
    public TorchScript torchScript;

    // Start is called before the first frame update
    void Start()
    {
        winGame = false;
        loseGame = false;
        playerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoviment>();
    }

    IEnumerator WinCondition()
    {
        playerScript.blockMove = true;
        torchScript.WinLights();
        victory.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("Game");
    }

    IEnumerator LoseCondition()
    {
        playerScript.blockMove = true;
        torchScript.LoseLights();
        defeat.SetActive(true);
        yield return new WaitForSeconds(5.0f);
        SceneManager.LoadScene("Game");
    }

    // Update is called once per frame
    void Update()
    {
        if (winGame == true)
        {
            StartCoroutine("WinCondition");
        }
        if (loseGame == true)
        {
            StartCoroutine("LoseCondition");
        }
    }
}
