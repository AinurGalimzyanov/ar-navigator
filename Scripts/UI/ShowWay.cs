using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowWay : MonoBehaviour
{
    public int Index;
    private ImageController ImageControllerScript;
    private Button Button;
    private Button SelectedWayButton;
    void Start()
    {
        ImageControllerScript = FindObjectOfType<ImageController>();
        Button = GetComponent<Button>();
        Button.onClick.AddListener(ShowWayFunction);
    }

    

    // Update is called once per frame
    void ShowWayFunction()
    {
        SelectedWayButton = ImageControllerScript.Buttons[ImageControllerScript.SelecteedWayIndex].GetComponent<Button>();
        SelectedWayButton.GetComponent<Image>().color = Color.white;
        GetComponent<Image>().color = Color.green;
        ImageControllerScript.SelecteedWayIndex = Index;
        ImageControllerScript.ShowWay = true;
    }
}
