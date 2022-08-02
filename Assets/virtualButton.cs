using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class virtualButton : MonoBehaviour
{
    public GameObject Objmodel;
    public VirtualButtonBehaviour vbutton;
    // Start is called before the first frame update
    void Start()
    {
        
        vbutton.RegisterOnButtonPressed(OnButtonPressed);
        vbutton.RegisterOnButtonReleased(OnButtonReleased);
        Objmodel.SetActive(false);
       
        
    }
    public void OnButtonPressed(VirtualButtonBehaviour VB){
        
        Objmodel.SetActive(true);
        
    }
    public void OnButtonReleased(VirtualButtonBehaviour VB){
        Objmodel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
