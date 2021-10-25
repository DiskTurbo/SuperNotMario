using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField]
    float size = 1;

    public bool isGridVisible = false;

    public Vector3 GetPoint(Vector3 position)
    {
        position = position - transform.position;

        int xCount = Mathf.RoundToInt(position.x / size);
        int yCount = Mathf.RoundToInt(position.y / size);
        int zCount = Mathf.RoundToInt(position.z / size);

        Vector3 result = new Vector3((float)xCount * size, (float)yCount * size, -1.325805f);

        result = result + transform.position;

        return result;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        for (float x = -40; x < 256; x += size)
        {
            for (float y = 0; y < 40; y += size)
            {
                var point = GetPoint(new Vector3(x, y, -1.325805f));
                if(isGridVisible == true)
                    Gizmos.DrawSphere(point, 0.1f);
            }

        }
    }
}