using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public Sprite[] sprite1;
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(PressBtnClose);
        button.onClick.Invoke();
    }

    void PressBtnClose() // 인자가 없는 메소드
    {
        print("Hello!");
    }
    public void DebugMes()
    {
        print("Hello world");
    }

    public void Textchange()
    {
        GetComponentInChildren<Text>().text = "Hello";
    }
    /*
    public void ChangeColor()
    {
        Button button = GetComponent<Button>();
        Colorblock colorb = 
        button.colors.normalColor = Color.gray;
    }*/


}
