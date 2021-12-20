using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerView : MonoBehaviour
{
	[SerializeField] private Text player0score = null;
	[SerializeField] private Text player1score = null;

	private void Start()
	{
		ScoreManager.Instance.Player0ScoreChanged += UpdatePlayer0ScoreView;
		ScoreManager.Instance.Player1ScoreChanged += UpdatePlayer1ScoreView;
	}

	public void UpdatePlayer0ScoreView(int newScore)
	{
		player0score.text = newScore.ToString();
	}

	public void UpdatePlayer1ScoreView(int newScore)
	{
		player1score.text = newScore.ToString();
	}
}
