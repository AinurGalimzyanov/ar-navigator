using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewActive : MonoBehaviour
{
    private Button Button;

    private ImageController ImageControllerScript;

    void Start()
    {
        ImageControllerScript = FindObjectOfType<ImageController>();

        Button = GetComponent<Button>();
        Button.onClick.AddListener(ScrollviewSetActive);
    }

    // Данный скрипт отвечает за появление / исчезновение выпадающего списка
    void ScrollviewSetActive()
    {
        if (ImageControllerScript.ScrollViewSetActive)
        {
            ImageControllerScript.ScrollViewSetActive = false;
        }
        else
        {
            ImageControllerScript.ScrollViewSetActive = true;
        }
    }
}
