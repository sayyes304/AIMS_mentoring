using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class debugray : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Button ActivationBtn;
    public void DebugRay()
    {
        ActivationBtn.onClick.Invoke();
        print("RayClick!");

    }
}
