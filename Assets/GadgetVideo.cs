using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class GadgetVideo : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject Mac, Case, Camera;
    VirtualButtonBehaviour[] virtualButton;


    // Start is called before the first frame update
    void Start()
    {
         virtualButton = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int v = 0; v < virtualButton.Length; v++)
        {
            virtualButton[v].RegisterEventHandler(this);
        }

        Camera.SetActive(false);
        Case.SetActive(false);
        Mac.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "MacButton":
                Mac.SetActive(true);
                Camera.SetActive(false);
                Case.SetActive(false);
                Debug.Log("MacButton");
                break;
            case "CaseButton":
                Mac.SetActive(false);
                Camera.SetActive(false);
                Case.SetActive(true);
                Debug.Log("CaseButton");
                break;
            case "CameraButton":
                Mac.SetActive(false);
                Camera.SetActive(true);
                Case.SetActive(false);
                Debug.Log("CameraButton");
                break;
            default:
                throw new UnityException("Button not found!");
        }
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }


}
