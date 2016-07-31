using UnityEngine;

public class ClickCamera : MonoBehaviour
{
    public float dragSpeed = 2;
    public float topBand;
    public float bottomBand;

    private Vector3 dragOrigin;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            return;
        }

        if (!Input.GetMouseButton(0)) return;

        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(0f, pos.y * dragSpeed, 0f);

        transform.Translate(move, Space.World);

        if (transform.position.y  > topBand)
        {
            transform.Translate(new Vector3(0f, -(transform.position.y - topBand), 0f));
        }

        if (transform.position.y < bottomBand)
        {
            transform.Translate(new Vector3(0f, -(transform.position.y - bottomBand), 0f));
        }

    }


}