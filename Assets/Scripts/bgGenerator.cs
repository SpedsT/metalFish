using UnityEngine;
using System.Collections;
//using UnityEngine.UI;

public class bgGenerator : MonoBehaviour
{
    public float speed;
    Vector3 Vec3;

    // Use this for initialization
    void Start()
    {
        //speed = 0.05f;
    }

    void Update()
    {
        gameObject.transform.Translate(-speed, 0, 0);

        if (gameObject.transform.position.x <= -19.50843f)
        {
            Vec3 = new Vector3(80.4407f, 2.5f, 0f);
            gameObject.transform.position = Vec3;
        }

    }
}