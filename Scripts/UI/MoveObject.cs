using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveObject : MonoBehaviour
{
    private Button Button;

    private ImageController ImageControllerScript;

    [SerializeField] private GameObject ObjectToMove;

    public Vector3 position;

    void Start()
    {
        ImageControllerScript = FindObjectOfType<ImageController>();

        Button = GetComponent<Button>();
        Button.onClick.AddListener(Move);
    }

    // Данный скрипт отвечает за перемещние гизмо
    private void Move()
    {
        // Поиск установленного гизмо на сцене
        ObjectToMove = GameObject.Find("Room(Clone)");
        // Изменение положения
        ObjectToMove.transform.position += position;
    }
}
