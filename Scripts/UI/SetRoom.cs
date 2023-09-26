using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetRoom : MonoBehaviour
{
    private Button Button;

    private ImageController ImageControllerScript;

    void Start()
    {
        ImageControllerScript = FindObjectOfType<ImageController>();

        Button = GetComponent<Button>();
        Button.onClick.AddListener(AnchorEnables);
    }

    // Данный скрипт отвечает за установку гизмо
    private void AnchorEnables()
    {
        ImageControllerScript.SetAnchor = true;
    }
}

