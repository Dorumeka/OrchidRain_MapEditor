using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class DoorSoundPlayer : GenericAudioPlayer {
	public DoorSoundType soundType;

	/*public override void Play () {
		if (clips.Length == 0) StartCoroutine(PlayWait_Door());
		else base.Play();
	}
	IEnumerator PlayWait_Door () {
		yield return null;
		PlayClip(audioSource, GetClip());
		//Debug.Log(GetClip());
	}

	AudioClip GetClip () {
		return SceneScript.gameSettings.gameLists.doorSoundBank.GetSound(soundType);
	}*/
}
