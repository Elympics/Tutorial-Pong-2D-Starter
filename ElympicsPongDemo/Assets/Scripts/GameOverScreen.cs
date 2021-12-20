using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
	[SerializeField] private GameObject mainContainer = null;
	[SerializeField] private GameObject player0winnerField = null;
	[SerializeField] private GameObject player1winnerField = null;

	private void Start()
	{
		ScoreManager.Instance.GameFinished += ShowGameOverScreen;
	}

	private void ShowGameOverScreen(int playerId)
	{
		mainContainer?.SetActive(true);

		player0winnerField?.SetActive(playerId == 0);
		player1winnerField?.SetActive(playerId == 1);
	}
}
