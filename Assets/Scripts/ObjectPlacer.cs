using UnityEngine;

public class ObjectPlacer : MonoBehaviour
{
    private Grid g;
    public GameObject[] objectArr;
    int currentObj = 0;

    private void Awake()
    {
        g = FindObjectOfType<Grid>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hitInfo))
            {
                PlaceObjectNear(hitInfo.point);
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
    }

    private void PlaceObjectNear(Vector3 clickPoint)
    {
        var finalPosition = g.GetPoint(clickPoint);
        GameObject item = Instantiate(objectArr[currentObj]);
        item.transform.position = finalPosition;
    }
}