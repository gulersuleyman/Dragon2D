using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] int score;
    public static GameManager Instance { get; private set; }
    public event System.Action<int> OnScoreChanged;
    public event System.Action OnSceneChanged;
    // Start is called before the first frame update
    private void Awake()
    {
        SingletonThisGameObject();
    }
    private void SingletonThisGameObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void IncreaseScore()
    {
        score++;
        
        OnScoreChanged?.Invoke(score);
    }
   

    private IEnumerator RestartGameAsync()
    {
        OnSceneChanged?.Invoke();
        yield return SceneManager.LoadSceneAsync("Game");
    }
    public void RestartGame()
    {
        score = 0;
        Time.timeScale = 1f;
        StartCoroutine(RestartGameAsync());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.RestartGame();
    }
}
