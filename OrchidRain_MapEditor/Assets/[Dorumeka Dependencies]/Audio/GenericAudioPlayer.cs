using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GenericAudioPlayer : AudioManager {
	[Space(5f)]
	[Header("Dependencies")]
	public AudioMixerGroup audioMixerGroup;
	public AudioClip[] clips;

	[Space(5f)]
	[Header("Variables")]
	public float volume = 1f;
	public float maxDistance = 20f;
	public bool non3D = false;

	protected AudioSource audioSource;

	void Start () {
		CreateAudioSource();
	}

	public virtual void Play () {
		StartCoroutine(PlayDelay());
	}
	IEnumerator PlayDelay () {
		yield return null;
		PlayClip(audioSource, clips);
	}

	public virtual void Play (float min, float max) {
		StartCoroutine(PlayDelay(min, max));
	}
	IEnumerator PlayDelay (float min, float max) {
		yield return null;
		PlayClip(audioSource, clips, min, max);
	}

	void CreateAudioSource () {
		audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.rolloffMode = AudioRolloffMode.Linear;
		audioSource.maxDistance = maxDistance;
		audioSource.volume = volume;
		audioSource.outputAudioMixerGroup = audioMixerGroup;

		if (non3D) audioSource.spatialBlend = 0f;
		else audioSource.spatialBlend = 1f;
	}

	public AudioSource AudioSource () {
		return audioSource;
	}

	public void PlaySingleClip (AudioClip ac) {
		PlayClipAlways (audioSource, ac);
	}
}
