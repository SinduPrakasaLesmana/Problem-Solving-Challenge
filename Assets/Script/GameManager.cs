using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region SINGLETON
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
                if (_instance == null) Debug.LogError("No Game Manager Found!!!");
            }
            return _instance;
        }
    }
    #endregion

    public int Score { get; private set; }

    [Header("Box Coin Controller")]
    public int coinSpawn;
    [SerializeField] BoxCoin boxCoinPrefab;

    [Header("Game area constraint")]
    public float areaConstraintValue = 5f;

    [Header("UI")]
    public Text scoreText;

    private void Start()
    {
        for (int i = 0; i < coinSpawn; i++)
        {
            BoxCoin coin = Instantiate(boxCoinPrefab);
            coin.Spawn();
        }
        scoreText.text = $"Score : {Score}";
    }

    public Vector2 GetRandomPosition()
    {
        float xPosition = Random.Range(-areaConstraintValue, areaConstraintValue);
        float yPosition = Random.Range(-areaConstraintValue, areaConstraintValue);

        return new Vector2(xPosition, yPosition);
    }

    public void AddScore()
    {
        Score++;
        scoreText.text = $"Score : {Score}";
    }
}