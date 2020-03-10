using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class SoundReceiver : EventReceiver {
	private GenericAudioPlayer _audioPlayer;

	void Start () {
		_audioPlayer = GetComponent<GenericAudioPlayer>();
	}

	public override void TriggerReceiver (EventInfo eventInfo) {
		base.TriggerReceiver(eventInfo);
		if (_audioPlayer) _audioPlayer.Play();
	}
}
