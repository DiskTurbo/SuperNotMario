using UnityEngine;

public class ObjectPlacer : MonoBehaviour
{
    private Grid g;
    public GameObject[] objectArr, imgArr;
    int currentObj = 0;
    ActivationArea activationArea;

    private void Awake()
    {
        g = FindObjectOfType<Grid>();
        activationArea = FindObjectOfType<ActivationArea>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitInfo))
            {
                Debug.Log(hitInfo.transform.tag);
                if (hitInfo.transform.tag != "Object" || hitInfo.transform.tag != "Enemy")
                {
                    PlaceObjectNear(hitInfo.point);
                }
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            currentObj++;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            currentObj--;
        }

        if(currentObj >= objectArr.Length)
        {
            currentObj = 0;
        }
        else if (currentObj < 0)
        {
            currentObj = objectArr.Length - 1;
        }
        for(int i = 0; i < objectArr.Length; i++)
        {
            if(i == currentObj)
            {
                imgArr[i].SetActive(true);
            }
            else
            {
                imgArr[i].SetActive(false);
            }
        }
    }

    public void SetObjectSpawn(int choice)
    {
        choice = currentObj;
    }

    private void PlaceObjectNear(Vector3 clickPoint)
    {
        var finalPosition = g.GetPoint(clickPoint);
        GameObject item = Instantiate(objectArr[currentObj]);
        item.transform.position = finalPosition;
    }
}