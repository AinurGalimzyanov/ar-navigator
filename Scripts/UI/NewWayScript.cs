using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewWayScript : MonoBehaviour
{
    private Button Button;

    private Button SelectedWayButton;

    private ImageController ImageControllerScript;

    void Start()
    {
        ImageControllerScript = FindObjectOfType<ImageController>();
        Button = GetComponent<Button>();
        Button.onClick.AddListener(NewButton);
    }

    // Данный скрипт отвечает за установку новой кнопки
    void NewButton()
    {
        ImageControllerScript.NewButton = true;
        // Получение компонента кнопки
        SelectedWayButton = ImageControllerScript.Buttons[ImageControllerScript.SelecteedWayIndex].GetComponent<Button>();
        // Изменение цвета кнопки
        SelectedWayButton.GetComponent<Image>().color = Color.white;
    }
}
