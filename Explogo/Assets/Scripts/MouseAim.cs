using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{

    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 5.0f;
    public float smoothness = 10.0f;

    GameObject player;

    bool moveAllowed = true;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        player = this.transform.parent.gameObject;
    }


    void toggleMoveAllowed()
    {

        if (moveAllowed == true)
        {
            moveAllowed = false;
        }
        else
        {
            moveAllowed = true;
        }

    }

    void destroyScript()
    {

        Destroy(this);

    }




    // Update is called once per frame
    void Update()
    {


        if (moveAllowed == true)
        {

            var mousePoint = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

            mousePoint = Vector2.Scale(mousePoint, new Vector2(sensitivity * smoothness, sensitivity * smoothness));

            smoothV.x = Mathf.Lerp(smoothV.x, mousePoint.x, 1f / smoothness);
            smoothV.y = Mathf.Lerp(smoothV.y, mousePoint.y, 1f / smoothness);
            mouseLook += smoothV;

            mouseLook.y = Mathf.Clamp(mouseLook.y, -40f, -5f);


            transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
            player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);

        }

        
    }
}
