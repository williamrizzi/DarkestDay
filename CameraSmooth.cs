using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSmooth : MonoBehaviour
{
    public float speed;
    public Vector3 pos;
    public int setorAtual;

    // Start is called before the first frame update
    void Start()
    {
        setorAtual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        switch (setorAtual)
        {
            case 0:
                pos = new Vector3(2.5f, -1.5f, -10);
                transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
                break;
            case 1:
                pos = new Vector3(37.5f, -1.5f, -10);
                transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
                break;
            case 2:
                pos = new Vector3(37.5f, -20.5f, -10);
                transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
                break;
            case 3:
                pos = new Vector3(2.5f, -20.5f, -10);
                transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
                break;
            case 4:
                pos = new Vector3(-32.5f, -20.5f, -10);
                transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
                break;
            case 5:
                pos = new Vector3(-32.5f, -1.5f, -10);
                transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
                break;
            case 6:
                pos = new Vector3(-32.5f, 17.5f, -10);
                transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
                break;
            case 7:
                pos = new Vector3(2.5f, 17.5f, -10);
                transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
                break;
            case 8:
                pos = new Vector3(37.5f, 17.5f, -10);
                transform.position = Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
                break;
        }

    }
}
