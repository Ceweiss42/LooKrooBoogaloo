using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace roundbeargames_tutorial
{
    public class CursorMove : MonoBehaviour
    {

        public Vector2 screenBounds;

        public void Start()
        {
            screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
            ClampToScreen(this.transform);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                this.transform.position += Vector3.up * 200 * Settings.cursorSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                this.transform.position += Vector3.left * 200 * Settings.cursorSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                this.transform.position += Vector3.down * 200 * Settings.cursorSpeed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.position += Vector3.right * 200 * Settings.cursorSpeed * Time.deltaTime;
            }
            ClampToScreen(this.transform);






        }

        public void ClampToScreen(Transform transform)
        {
            Vector3 pos = transform.position;

            pos.x = Mathf.Clamp(pos.x, screenBounds.x * 10, screenBounds.x * -10);
            pos.y = Mathf.Clamp(pos.y, screenBounds.y * 10, screenBounds.y * -10);
            transform.position = pos;
        }
        public void OnDrag(PointerEventData eventData)
        {
            transform.position = eventData.position;
        }
    }

}
