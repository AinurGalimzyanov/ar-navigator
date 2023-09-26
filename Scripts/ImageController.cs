using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ImageController : MonoBehaviour
{
    public GameObject Anchor;

    public GameObject Room;
    
    public GameObject AnchorController;
    private GameObject SaveButton;
    private GameObject MoveButtons;
    private GameObject SetGizmoButton;
    private GameObject MarkerButton;
    public GameObject ScrollView;
    public GameObject ARCamera;

    public GameObject[] Buttons;
    public GameObject ButtonPrefab;
    public GameObject Content;
    public GameObject[] Ways;
    public GameObject WayPointPrefab;
    public GameObject VersionOfWay;
    public GameObject WayPoint;

    public GameObject PlaneMarkerPrefab;

    public bool SetAnchor = false;
    public bool SaveAnchor = false;
    public bool ScrollViewSetActive = false;
    public bool NewButton = false;
    public bool AddObjectsToWay = false;
    public bool AddArrow = false;
    public bool ShowWay = false;

    public int Index = 0;
    public int SelecteedWayIndex;
    public int[] NumberOfWayPoint = new int[100];
    public int CountOfWayPoints = 0;
    private float distance = 0;
    public float[,] PositionOfPoints_x = new float[100,100];
    public float[,] PositionOfPoints_y = new float[100, 100];
    public float[,] PositionOfPoints_z = new float[100, 100];

    private Vector2 TouchPosition;

    private ARTrackedImageManager ARTrackedImageManagerScript;
    private ARRaycastManager ARRaycastManagerScript;
    public ShowWay ShowWayScript;
    private Quaternion YRotation;

    private void Awake()
    {
        ARTrackedImageManagerScript = FindObjectOfType<ARTrackedImageManager>();
        ARRaycastManagerScript = FindObjectOfType<ARRaycastManager>();

        SaveButton = GameObject.Find("ControllButtons/SaveButton");
        MoveButtons = GameObject.Find("ControllButtons/MoveButtons");
        SetGizmoButton = GameObject.Find("ControllButtons/SetGizmoButton");
        MarkerButton = GameObject.Find("MarkerButton");
        ScrollView = GameObject.Find("Scroll View");

        SaveButton.SetActive(false);
        MoveButtons.SetActive(false);
        MarkerButton.SetActive(false);
        ScrollView.SetActive(false);
    }

    void Update()
    {
        AnchorControll();
       
        AddNewWay();

        MoveAndRotateObject();

        if (AddObjectsToWay && AddArrow)
        {
            ShowMarkerAndSetObject();
        }

        if (ShowWay)
        {
            int i = 0;
            while (i <= Index)
            {     
                Ways[i].SetActive(false);
                i++;
                if (i >= Index)
                {
                    Ways[SelecteedWayIndex].SetActive(true);
                    ShowWay = false;
                }
            }
        }

    }

    private void AnchorControll()
    {
        Anchor = GameObject.FindWithTag("Anchor");
        Anchor.name = "Anchor";

        if (SetAnchor)
        {
            Instantiate(Room, Anchor.transform.position, Anchor.transform.rotation);

            ARTrackedImageManagerScript.SetTrackablesActive(false);

            SetAnchor = false;
            SetGizmoButton.SetActive(false);
            SaveButton.SetActive(true);
            MoveButtons.SetActive(true);
        }
        else if (SaveAnchor)
        {
            AnchorController.SetActive(false);
            MarkerButton.SetActive(true);
        }

        if (ScrollViewSetActive)
        {
            ScrollView.SetActive(true);
        }
        else
        {
            ScrollView.SetActive(false);
        }
    }

    public void AddNewWay()
    {
        if (NewButton)
        {
            Buttons[Index] = Instantiate(ButtonPrefab);
            Buttons[Index].transform.parent = Content.gameObject.transform;
            Buttons[Index].transform.GetChild(0).GetComponent<Text>().text = (124 + Index).ToString();

            ShowWayScript = Buttons[Index].GetComponent<ShowWay>();

            ShowWayScript.Index = Index;

            Ways[Index] = Instantiate(VersionOfWay, Room.transform.position, Room.transform.rotation);
            
            WayPoint = Instantiate(WayPointPrefab, ARCamera.transform.position, ARCamera.transform.rotation);
            WayPoint.gameObject.transform.parent = Ways[Index].gameObject.transform;
           
            SelecteedWayIndex = Index;
            AddObjectsToWay = true;
            ScrollViewSetActive = false;
            NewButton = false;
            distance = 0;
            CountOfWayPoints = 1;
            Index += 1;
        }
    }

    private void AddObjectToWayFunction(List<ARRaycastHit> hits)
    {
            WayPoint = Instantiate(WayPointPrefab, hits[0].pose.position, Quaternion.Euler(WayPointPrefab.transform.rotation.x, ARCamera.transform.rotation.y, WayPointPrefab.transform.rotation.z));
            
            /*PositionOfPoints_x[Index - 1, CountOfWayPoints - 1] = WayPoint.gameObject.transform.position.x;
            PositionOfPoints_y[Index - 1, CountOfWayPoints - 1] = WayPoint.gameObject.transform.position.y;
            PositionOfPoints_z[Index - 1, CountOfWayPoints - 1] = WayPoint.gameObject.transform.position.z;*/
            CountOfWayPoints++;
            NumberOfWayPoint[Index-1] = CountOfWayPoints;
            WayPoint.gameObject.transform.parent = Ways[Index - 1].gameObject.transform;
        AddArrow = false;
    }

    void ShowMarkerAndSetObject()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();

        ARRaycastManagerScript.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);

        // show marker
        if (hits.Count > 0)
        {
            PlaneMarkerPrefab.transform.position = hits[0].pose.position;
            PlaneMarkerPrefab.SetActive(true);
        }
        // set object
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            AddObjectToWayFunction(hits);
            /*PositionOfPoints_x[1, 1] = 1;
            PositionOfPoints_y[1, 1] = 1;
            PositionOfPoints_z[1, 1] = -2;
            PositionOfPoints_x[1, 2] = 2;
            PositionOfPoints_y[1, 2] = 2;
            PositionOfPoints_z[1, 2] = -2;
            PositionOfPoints_x[1, 3] = -2;
            PositionOfPoints_y[1, 3] = -2;
            PositionOfPoints_z[1, 3] = -2;
            PositionOfPoints_x[1, 4] = 0.2f;
            PositionOfPoints_y[1, 4] = 0.2f;
            PositionOfPoints_z[1, 4] = -2;*/
            PlaneMarkerPrefab.SetActive(false);
        }
    }

    void MoveAndRotateObject()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            TouchPosition = touch.position;
            
            
            if (touch.phase == TouchPhase.Began)
            {
                Camera ArCameraCamera = ARCamera.GetComponent<Camera>();
                Ray ray = ArCameraCamera.ScreenPointToRay(touch.position);
                RaycastHit hitObject;

                if (Physics.Raycast(ray, out hitObject))
                {
                    if (hitObject.collider.CompareTag("UnSelected"))
                    {
                        hitObject.collider.gameObject.tag = "Selected";
                    }
                }
            }

           GameObject SelectedObject = GameObject.FindWithTag("Selected");

            if (touch.phase == TouchPhase.Moved && Input.touchCount == 1)
            {
                List<ARRaycastHit> hits = new List<ARRaycastHit>();
                ARRaycastManagerScript.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);

                ARRaycastManagerScript.Raycast(TouchPosition, hits, TrackableType.Planes);
                SelectedObject.transform.position = hits[0].pose.position;
            }
            //Rotate Objec by 2 fingers
            if (Input.touchCount == 2)
            {
                Touch touch1 = Input.touches[0];
                Touch touch2 = Input.touches[1];

                if (touch1.phase == TouchPhase.Moved || touch2.phase == TouchPhase.Moved)
                {
                    float DistanceBetweenTouches = Vector2.Distance(touch1.position, touch2.position);
                    float prevDistanceBetweenTouches = Vector2.Distance(touch1.position - touch1.deltaPosition, touch2.position - touch2.deltaPosition);
                    float Delta = DistanceBetweenTouches - prevDistanceBetweenTouches;

                    if (Mathf.Abs(Delta) > 0)
                    {
                        Delta *= 0.1f;
                    }
                    else
                    {
                        DistanceBetweenTouches = Delta = 0;
                    }
                    YRotation = Quaternion.Euler(0f, -touch1.deltaPosition.x * Delta, 0f);
                    SelectedObject.transform.rotation = YRotation * SelectedObject.transform.rotation;
                }

            }
            // Deselect object
            if (touch.phase == TouchPhase.Ended)
            {
                if (SelectedObject.CompareTag("Selected"))
                {
                    SelectedObject.tag = "UnSelected";
                }
            }
        }
    }

    private void SetWays()
    {
        PositionOfPoints_x[1, 1] = 1;
        PositionOfPoints_y[1, 1] = 1;
        PositionOfPoints_z[1, 1] = 1;
        PositionOfPoints_x[1, 2] = 4;
        PositionOfPoints_y[1, 2] = 4;
        PositionOfPoints_z[1, 2] = 4;
        
    }
}
