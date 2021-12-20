using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BallHitImpact : MonoBehaviour
{
	private AudioSource audioSource = null;

	private void Awake()
	{
		audioSource = GetComponent<AudioSource>();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		audioSource.Play();
	}
}
