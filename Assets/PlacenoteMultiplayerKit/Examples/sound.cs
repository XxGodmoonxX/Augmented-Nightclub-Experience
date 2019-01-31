using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text使うため

public class sound : MonoBehaviour {

	private AudioSource audio;

	public int noteNumberNum;
	public void ReturnAccess(){
  	Debug.Log ("アクセス成功！！");
  }

	//スマホ上にSoundのなんかの変数表示
	// public GameObject soundCanvas; //Text

	public float volume;

	// Use this for initialization
	public void Start () {
		// 空の Audio Sourceを取得
		audio = GetComponent<AudioSource>();
		// Audio Source の Audio Clip をマイク入力に設定
    // マイク名nullならデフォルト、ループするかどうか、AudioClipの秒数、サンプリングレート を指定する
    audio.clip = Microphone.Start(null, true, 10, 44100);
		// マイクが Ready になるまで待機（一瞬）
		while (Microphone.GetPosition(null) <= 0) {}
		// 再生開始（録った先から再生、スピーカーから出力するとハウリングします）
    audio.Play();

		//スマホ上にSoundのなんかの変数表示
		// Text sound_text = soundCanvas.GetComponent<Text>();
		// sound_text.text = 0.ToString();
	}

	// Update is called once per frame
	public void Update () {
		//音声データの周波数成分を解析する
		float[] spectrum = new float[256];
		//音声出力のサンプリングレートを F , spectrum の長さを Q とすると spectrum[N] には N * F/2 / Q Hzの周波数成分が含まれています。
    AudioListener.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);
		// Debug.Log(spectrum.Length);

		//ピッチの取得
		// var maxIndex = 0;
		// var maxValue = 0.0f;
		// for (int i = 0; i < spectrum.Length; i++) {
		// 	var val = spectrum[i];
		// 	if (val > maxValue) {
		// 		// maxValue が最も大きい周波数成分の値で
		// 		maxValue = val;
		// 		// maxIndex がそのインデックス。欲しいのはこっち。
		// 		maxIndex = i;
		// 	}
		// }

		// var freq = maxIndex * AudioSettings.outputSampleRate / 2 / spectrum.Length;
		// 周波数からMIDIノートナンバーを計算
    // var noteNumber = CalculateNoteNumberFromFrequency(freq);
		// Debug.Log(noteNumber);
		// noteNumberNum = noteNumber;

		//スマホ上にSoundのなんかの変数表示
		// Text sound_text = soundCanvas.GetComponent<Text>();
		// sound_text.text = noteNumber.ToString();

		//音量取得
		// float vol = GetAveragedVolume();
		volume = GetAveragedVolume();
		Debug.Log(volume);

		//周波数解析、各周波数ごとの音量取得
		for (int i = 0; i < spectrum.Length; i++) {
		}
	}

	//周波数が計算できたので、最後にこれを音名に変換します。周波数と音名の対応はMIDI tuning standardによると以下のようにして計算できます。
	// public static int CalculateNoteNumberFromFrequency(float freq) {
  // 	return Mathf.FloorToInt(69 + 12 * Mathf.Log(freq / 440, 2));
	// }

	float GetAveragedVolume() {
    float[] data = new float[256];
    float a = 0;
    audio.GetOutputData(data, 0);
    foreach (float s in data)
    {
      a += Mathf.Abs(s);
    }
    return a / 256.0f;
  }
}
