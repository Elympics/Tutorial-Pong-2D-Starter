using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ScoreManagerAudio : MonoBehaviour
{
    [SerializeField] private AudioClip matchPointClip = null;
    [SerializeField] private AudioClip matchVictoryClip = null;

	private AudioSource audioSource = null;

	private void Start()
	{
		audioSource = GetComponent<AudioSource>();

		ScoreManager.Instance.Player0ScoreChanged += PlayMatchPointAudioClip;
		ScoreManager.Instance.Player1ScoreChanged += PlayMatchPointAudioClip;

		ScoreManager.Instance.GameFinished += PlayMatchVictoryAudioClip;
	}

	private void PlayMatchPointAudioClip(int point)
	{
		audioSource.clip = matchPointClip;
		audioSource.Play();
	}

	private void PlayMatchVictoryAudioClip(int playerId)
	{
		audioSource.clip = matchVictoryClip;
		audioSource.Play();
	}
}
