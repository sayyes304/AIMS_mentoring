using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TexttoSpeech : MonoBehaviour
{
    public Text readingEng;

    string url = "https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=100&client=tw-ob&q=";
    AudioSource audio;

    // 최대 문자 길이 설정
    int maxCharLength = 100;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    IEnumerator PlaySpeak(string str)
    {
        WWW www = new WWW(str);
        yield return www;

        audio.clip = www.GetAudioClip(false, true, AudioType.MPEG);
        audio.Play();

        // 오디오 재생이 끝날 때까지 대기
        while (audio.isPlaying)
        {
            yield return null;
        }
    }

    string getString(string text)
    {
        return text + "&tl=En";
    }

    public void EngBtn()
    {
        StartCoroutine(SpeakText(readingEng.text));
    }

    IEnumerator SpeakText(string text)
    {
        // 텍스트를 여러 부분으로 나눔
        List<string> textParts = SplitText(text, maxCharLength);

        // 각 부분을 순차적으로 처리
        foreach (string part in textParts)
        {
            yield return StartCoroutine(PlaySpeak(url + getString(part)));
        }
    }

    // 텍스트를 여러 부분으로 나누는 함수
    List<string> SplitText(string text, int maxLength)
    {
        List<string> parts = new List<string>();

        while (text.Length > maxLength)
        {
            string part = text.Substring(0, maxLength);
            parts.Add(part);
            text = text.Substring(maxLength);
        }

        if (text.Length > 0)
        {
            parts.Add(text);
        }

        return parts;
    }
}
