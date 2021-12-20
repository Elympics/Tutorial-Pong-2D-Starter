using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGoal : MonoBehaviour
{
	[SerializeField] private int playerGettingPointOnCatch = 0;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.GetComponent<Ball>() != null)
		{
			ScoreManager.Instance?.AddPoint(playerGettingPointOnCatch);
		}
	}
}
