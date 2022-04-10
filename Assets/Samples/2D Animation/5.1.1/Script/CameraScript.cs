using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform Player;
    Vector3 Target;

    public float TrackinSpeed = 1.5f;

    // Обновление вызывается один раз за кадр
    void Update()
    {
        if (Player)
        {
            Vector3 currentPosition = Vector3.Lerp(transform.position, Target, TrackinSpeed * Time.deltaTime);
            transform.position = currentPosition;
            Target = new Vector3(Player.transform.position.x, Player.transform.position.y, transform.position.z);
        }
    }
}
