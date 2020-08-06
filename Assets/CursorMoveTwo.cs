using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMoveTwo : MonoBehaviour
{
    public Vector2 screenBounds;

    public void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.up * 200 * Settings.cursorSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * 200 * Settings.cursorSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.down * 200 * Settings.cursorSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * 200 * Settings.cursorSpeed * Time.deltaTime;
        }

        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, screenBounds.x * 10, screenBounds.x * -10);
        pos.y = Mathf.Clamp(pos.y, screenBounds.y * 10, screenBounds.y * -10);
        transform.position = pos;



    }
}
