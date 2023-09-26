using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public ImageController ImageControllerScript;

    private void Awake()
    {
        ImageControllerScript = FindObjectOfType<ImageController>();
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer(this);
        
        for (int i = 0; i <= data.NumberOfWay - 1; i++)
        {
            ImageControllerScript.NewButton = true;
            ImageControllerScript.AddNewWay();
            Button button = ImageControllerScript.Buttons[ImageControllerScript.SelecteedWayIndex].GetComponent<Button>();
            button.GetComponent<Image>().color = Color.white;
            for (int j = 0; j <= data.NumberOfWayPoint[i]; j++)
            {
                ImageControllerScript.WayPoint = Instantiate(ImageControllerScript.WayPointPrefab, new Vector3(data.PositionOfPoints_x[i, j], data.PositionOfPoints_y[i, j], data.PositionOfPoints_z[i, j]), ImageControllerScript.WayPointPrefab.transform.rotation);
                ImageControllerScript.WayPoint.gameObject.transform.parent = ImageControllerScript.Ways[ImageControllerScript.Index - 1].gameObject.transform;
                ImageControllerScript.WayPoint.gameObject.transform.position = new Vector3(data.PositionOfPoints_x[i, j], data.PositionOfPoints_y[i, j], data.PositionOfPoints_z[i, j]);
            }
        }
    }
}
