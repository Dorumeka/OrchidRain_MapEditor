using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour {

	public void PlayClip (AudioSource a, AudioClip ac) {
		if (!a.isPlaying) {
			a.clip = ac;
			a.Play();
		}
	}
	public void PlayClip (AudioSource a, AudioClip ac, float min, float max) {
		if (!a.isPlaying) {
			a.clip = ac;
			float p = Random.Range(min, max);
			a.pitch = p;
			a.Play();
		}
	}
	public void PlayClip (AudioSource a, AudioClip[] ac) {
		if (ac.Length > 0 && !a.isPlaying) {
			int r = Random.Range(0, ac.Length);
			a.clip = ac[r];
			a.Play();
		}
	}
	public void PlayClip (AudioSource a, AudioClip[] ac, float min, float max) {
		if (ac.Length > 0 && !a.isPlaying) {
			int r = Random.Range(0, ac.Length);
			a.clip = ac[r];
			float p = Random.Range(min, max);
			a.pitch = p;
			a.Play();
		}
	}

	public void PlayClipAlways (AudioSource a, AudioClip ac) {
		a.clip = ac;
		a.Play();
	}
	public void PlayClipAlways (AudioSource a, AudioClip ac, float min, float max) {
		a.clip = ac;
		float p = Random.Range(min, max);
		a.pitch = p;
		a.Play();
	}
	public void PlayClipAlways (AudioSource a, AudioClip[] ac) {
		if (ac.Length > 0) {
			int r = Random.Range(0, ac.Length);
			a.clip = ac[r];
			a.Play();
		}
	}
	public void PlayClipAlways (AudioSource a, AudioClip[] ac, float min, float max) {
		if (ac.Length > 0) {
			int r = Random.Range(0, ac.Length);
			a.clip = ac[r];
			float p = Random.Range(min, max);
			a.pitch = p;
			a.Play();
		}
	}
}
