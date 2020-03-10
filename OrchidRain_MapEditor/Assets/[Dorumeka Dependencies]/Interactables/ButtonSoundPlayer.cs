using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ButtonSoundPlayer : GenericAudioPlayer {
	public ButtonSoundType soundType;

	/*public override void Play () {
		if (clips.Length == 0) StartCoroutine(PlayWait_Button());
		else base.Play();
	}
	IEnumerator PlayWait_Button () {
		yield return null;
		PlayClip(audioSource, GetClip());
	}

	AudioClip GetClip () {
		return SceneScript.gameSettings.gameLists.buttonSoundBank.GetSound(soundType);
	}*/
}
