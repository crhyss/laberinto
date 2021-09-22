using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{

    public float smoothTime = 3f;

    Transform target;
    float tLX, tLY, bRX, bRY;

    Vector2 velocity;

    void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Start()
    {
        // Forzar la resoluci�n si no estamos en versi�n Web
        if (Application.platform != RuntimePlatform.WebGLPlayer)
            Screen.SetResolution(800, 800, true);
    }

    void Update()
    {

        // Forzar la resoluci�n si no estamos en versi�n Web
        if (Application.platform != RuntimePlatform.WebGLPlayer)
        {
            // Si no es cuadrada o pantalla completa
            if (!Screen.fullScreen || Camera.main.aspect != 1)
                Screen.SetResolution(800, 800, true);
            // Permitir cerrar juego al presionar escape
            if (Input.GetKey("escape"))
                Application.Quit();
        }

        float posX = Mathf.Round(
            Mathf.SmoothDamp(transform.position.x,
                target.position.x, ref velocity.x, smoothTime
            ) * 100) / 100;

        float posY = Mathf.Round(
            Mathf.SmoothDamp(transform.position.y,
                target.position.y, ref velocity.y, smoothTime
            ) * 100) / 100;

        transform.position = new Vector3(
            Mathf.Clamp(posX, tLX, bRX),
            Mathf.Clamp(posY, bRY, tLY),
            transform.position.z
        );

    }

    public void SetBound(GameObject map)
    {
        SuperTiled2Unity.SuperMap config = map.GetComponent<SuperTiled2Unity.SuperMap>();
        float cameraSize = Camera.main.orthographicSize;

        tLX = map.transform.position.x + cameraSize;
        tLY = map.transform.position.y - cameraSize;
        bRX = map.transform.position.x + config.m_Width - cameraSize;
        bRY = map.transform.position.y - config.m_Height + cameraSize;

        FastMove();
    }

    public void FastMove()
    {

        transform.position = new Vector3(
            target.position.x,
            target.position.y,
            transform.position.z
        );

    }

}