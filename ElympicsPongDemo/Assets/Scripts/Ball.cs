using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
	[SerializeField] private float startSpeed = 1.0f;
	[SerializeField] private float speedIncreasePerHit = 0.1f;

	private Vector2 startDirection = new Vector2(1, 1);
	private new Rigidbody2D rigidbody = null;

	public void Awake()
	{
		rigidbody = GetComponent<Rigidbody2D>();
		ResetMovement();
	}

	public void ResetMovement()
	{
		rigidbody.velocity = startDirection * startSpeed;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Player")
			rigidbody.velocity += rigidbody.velocity * speedIncreasePerHit;
	}
}
