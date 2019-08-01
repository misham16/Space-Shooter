using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public AudioSource musicSource;
    public AudioClip musicClipOne;
    public AudioClip musicClipTwo;
    

    public Text scoreText;
    public Text restartText;
    public Text gameOverText;
    public Text winText;
    public Text titleText;

    public bool gameOver;
    private bool restart;
    public int score;
    
    void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        winText.text = "";
        titleText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
    }

    void Update()
    {
        if(restart)
        {
            if(Input.GetKeyDown (KeyCode.F))
            {
                SceneManager.LoadScene("final main");
            }
            if(Input.GetKeyDown (KeyCode.T))
            {
                SceneManager.LoadScene("Title");
            }
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds (startWait);
        while(true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range (0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate (hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds (spawnWait);
            }
            yield return new WaitForSeconds (waveWait);
            if (gameOver)
            {
                restartText.text = "Press 'F' for Restart";
                restart = true;
                titleText.text = "Press 'T' for Title";
                break;
            }
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
    void UpdateScore()
    {
        scoreText.text = "Points: " + score;
        if (score >= 100)
          {
            winText.text = "You win!";
            gameOver = true;
            restart = true;
            musicSource.clip = musicClipOne;
            musicSource.Play ();
           }
    }
    public void GameOver ()
    {
        gameOverText.text = "Game created by Misha McLendon";
        gameOver = true;
        musicSource.clip = musicClipTwo;
        musicSource.Play ();
    }
}
