using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float speed = 1.0f;

	private new Rigidbody2D rigidbody = null;

	private void Awake()
	{
		rigidbody = GetComponent<Rigidbody2D>();
	}

	public void ApplyMovement(float movementDirection)
	{
		rigidbody.velocity = Vector2.up * movementDirection * speed;
	}
}