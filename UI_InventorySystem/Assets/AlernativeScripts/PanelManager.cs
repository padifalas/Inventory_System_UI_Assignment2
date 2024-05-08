using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject[] panels; // Array to hold all panels
    private int currentIndex = 0; // Index of the currently active panel

    private void Start()
    {
        // Show the first two panels
        ShowPanels();
    }

    // Method to show two panels at a time
    private void ShowPanels()
    {
        // Hide all panels first
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }

        // Show the current and next panels
        panels[currentIndex].SetActive(true);
        int nextIndex = (currentIndex + 1) % panels.Length; // Wrap around to the beginning if needed
        panels[nextIndex].SetActive(true);
    }

    // Method to handle button click to move to the next panels
    public void MoveToNextPanels()
    {
        // Increment the current index
        currentIndex++;

        // Wrap around to the beginning if needed
        if (currentIndex >= panels.Length)
        {
            currentIndex = 0;
        }

        // Show the next tTwo panels
        ShowPanels();
    }
}