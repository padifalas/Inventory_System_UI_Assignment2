using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour
{
    public GameObject popupPanel;

    public void ShowPopup(string message)
    {
        popupPanel.SetActive(true);
        // Optionally, update text in the popup with the provided message
        // popupPanel.GetComponentInChildren<Text>().text = message;
    }

    public void HidePopup()
    {
        popupPanel.SetActive(false);
    }
}

