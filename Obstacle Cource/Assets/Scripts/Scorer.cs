using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    [SerializeField] private int _hits = 0;
    private int score;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;
    public Vector3[] targetLocations;
    public TextMeshProUGUI countdownText;
    public float currentTime = 15;

    void Update()
    {
        score = _hits;
        scoreText.text = "Score: " + score.ToString();
        currentTime -= Time.deltaTime;
        countdownText.text = currentTime.ToString();
        StartCoroutine(countdown());
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            _hits++;
            transform.position = targetLocations[Random.Range(0 ,targetLocations.Length)];
            Destroy(other.gameObject);
        }    
    }
    IEnumerator countdown()
    {
        yield return new WaitForSeconds(15);
        PlayerPrefs.SetInt("FinalScore", score);
        SceneManager.LoadScene(2);
    }
}