using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CountdownTimer : MonoBehaviour
{
    public string LevelToLoad;
    public float timer = 300f;
    private Text timerSeconds;


    // Use this for initialization
    void Start()
    {
        timerSeconds = GetComponent<Text>();
        StartCoroutine(LoadLevelAfterDelay(timer));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("Choice");
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f0");
        if (timer <= 0)
        {

        }
    }

    }
