using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
	[Header("Settings:")]
	[SerializeField] private int playerId = -1;

	private PlayerMovement playerMovement = null;

	private float movementY = 0.0f;

	private void Awake()
	{
		playerMovement = GetComponent<PlayerMovement>();
	}

	private void Update()
	{
		if (playerId == 0)
			movementY = Input.GetAxis("Vertical Player 0");
		else if (playerId == 1)
			movementY = Input.GetAxis("Vertical Player 1");
	}

	private void FixedUpdate()
	{
		playerMovement.ApplyMovement(movementY);
	}
}
