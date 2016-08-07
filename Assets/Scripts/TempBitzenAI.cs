using UnityEngine;
using System.Collections;

public class TempBitzenAI : MonoBehaviour {

    public float target;
    public float moveSpeed;
    public float topVariance;

    

    void Start ()
    {
        if (topVariance == 0f)
        {
            topVariance = moveSpeed / 10;
        }
    float bot = 0f;
    float top = 1.0f;
    float mid = Random.Range(bot, top);
        if (mid >= (top / 2))
        {
            moveSpeed += Random.Range(0f, topVariance);
        }
        else
        {
            moveSpeed -= Random.Range(0f, topVariance);
        }
    }

    bool IsGrounded ()
    {
        Debug.DrawRay(transform.position, -Vector3.up, Color.blue);
        Debug.Log(Physics2D.Raycast(transform.position, -Vector3.up, 0.001f));
        return Physics2D.Raycast(transform.position, -Vector3.up, 0.001f);
        //return true;
    }

	void Update ()
    {
        if (IsGrounded())
        {
            transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0f, 0f));
        }
	}
}
