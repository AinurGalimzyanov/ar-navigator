using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveWay : MonoBehaviour
{
    private Button Button;

    private ImageController ImageControllerScript;

    void Start()
    {
        ImageControllerScript = FindObjectOfType<ImageController>();

        Button = GetComponent<Button>();
        Button.onClick.AddListener(SaveWayFunction);
    }

    // Данный скрипт отвечает за сохранение нового маршрута
    private void SaveWayFunction()
    {
        ImageControllerScript.AddObjectsToWay = false;
    }
}
