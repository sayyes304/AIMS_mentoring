using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TexttoSpeech : MonoBehaviour
{
    public Text readingEng;

    string eng = "En";
    string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=";

    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    IEnumerator PlaySpeak(string str)
    {
        WWW www = new WWW(str); // 인터넷 주소를 받아옴
        yield return www;

        audio.clip = www.GetAudioClip(false, true, AudioType.MPEG);
        audio.Play();
    }

    string getString(string text, string stateName)
    {
        return text + "&tl=" + stateName + "-gb";
    }

    public void EngBtn()
    {
        StartCoroutine(PlaySpeak(url + getString(readingEng.text, eng)));
    }
}
