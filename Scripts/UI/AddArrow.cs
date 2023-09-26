using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddArrow : MonoBehaviour
{
    private Button Button;

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
        ImageControllerScript.AddArrow = true;
    }
}
