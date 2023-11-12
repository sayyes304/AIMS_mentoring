using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public Sprite[] sprite1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
