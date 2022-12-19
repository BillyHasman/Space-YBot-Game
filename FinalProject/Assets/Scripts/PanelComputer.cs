using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelComputer : MonoBehaviour
{
    public static bool KeyCard;
    public bool open;
    public bool close;
    public bool inTrigger;
    // public GameObject textUiNeedKey;
    // public GameObject ePrompt;
    public GameObject panelComputer;

    private void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
        // if (inTrigger = true)
        // {
        //     if (open)
        //     {
        //         GUI.Box(new Rect(0, 0, 200, 250), "Press E to exit panel");
        //     }
        //     else
        //     {
        //         if (KeyCard)
        //         {
        //             GUI.Box(new Rect(0, 0, 200, 250), "Press E to open panel");
        //         }
        //         else
        //         {
        //             textUiNeedKey.SetActive(true);

        //             // GUI.Box(new Rect(0, 0, 200, 250), "Access denied (need key card)");
        //         }
        //     }
        // }
    }
    private void OnTriggerExit(Collider other)
    {
        inTrigger = false;
        // if (inTrigger = false)
        // {
        //     if (open)
        //     {
        //         GUI.Box(new Rect(0, 0, 200, 250), "Press E to exit panel");
        //     }
        //     else
        //     {
        //         if (KeyCard)
        //         {
        //             GUI.Box(new Rect(0, 0, 200, 250), "Press E to open panel");
        //         }
        //         else
        //         {
        //             textUiNeedKey.SetActive(false);

        //             // GUI.Box(new Rect(0, 0, 200, 250), "Access denied (need key card)");
        //         }
        //     }
        // }
    }

    // Start is called before the first frame update
    void Start()
    {
        // textUiNeedKey.SetActive(false);
        panelComputer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (inTrigger)
        {
            if (close)
            {
                if (KeyCard)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        open = true;
                        close = false;
                    }
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    close = true;
                    open = false;
                }
            }
        }

        if (inTrigger)
        {
            if (open)
            {
                panelComputer.SetActive(true);
            }
            else
            {
                panelComputer.SetActive(false);
            }
        }
    }

    private void OnGUI()
    {
        GUIStyle myButtonStyle = new GUIStyle(GUI.skin.button);
        myButtonStyle.fontSize = 50;
        if (inTrigger)
        {
            if (open)
            {
                GUI.Box(new Rect(0, 0, 800, 150), "Press E to exit panel", myButtonStyle);
            }
            else
            {
                if (KeyCard)
                {
                    GUI.Box(new Rect(0, 0, 800, 150), "Press E to open panel", myButtonStyle);
                }
                else
                {
                    // textUiNeedKey.SetActive(true);

                    GUI.Box(new Rect(0, 0, 800, 150), "Access denied (need key card)", myButtonStyle);
                }
            }
        }
    }
}
