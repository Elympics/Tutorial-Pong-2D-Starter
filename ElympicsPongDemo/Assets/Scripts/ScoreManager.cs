using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
	[SerializeField] private Vector3 ballSpawnPoint = Vector3.zero;
	[SerializeField] private GameObject ballPrefab = null;
	[SerializeField] private int requiredScoreToWin = 5;

	public static ScoreManager Instance = null;

	private int player0score = 0;
	public event Action<int> Player0ScoreChanged = null;

	private int player1score = 0;
	public event Action<int> Player1ScoreChanged = null;

	public event Action<int> GameFinished = null;

	private GameObject ballReference = null;

	private void Awake()
	{
		if (ScoreManager.Instance == null)
			ScoreManager.Instance = this;
		else
			Destroy(this);
	}

	private void Start()
	{
		ResetGame();
	}

	public void AddPoint(int playerId)
	{
		if (playerId == 0)
		{
			player0score++;
			Player0ScoreChanged?.Invoke(player0score);
		}
		else if (playerId == 1)
		{
			player1score++;
			Player1ScoreChanged?.Invoke(player1score);
		}

		if (player0score == requiredScoreToWin || player1score == requiredScoreToWin)
			FinishGame();
		else
			ResetGame();
	}

	private void ResetGame()
	{
		if (ballReference != null)
			Destroy(ballReference);

		ballReference = Instantiate(ballPrefab);
		ballReference.transform.position = ballSpawnPoint;
	}

	private void FinishGame()
	{
		if (ballReference != null)
			Destroy(ballReference);

		GameFinished?.Invoke(player0score > player1score ? 0 : 1);
	}
}
