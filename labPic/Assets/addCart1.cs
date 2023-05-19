using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class addCart1 : MonoBehaviour
{
    
    public void OnMake()
    {
        string ClickedButtonName = EventSystem.current.currentSelectedGameObject.name; 
        Debug.Log(ClickedButtonName + " is created !!");
    }

}
