using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] List<GameObject> Cameras;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject i in Cameras)
        {
            i.SetActive(false);
        }

        Cameras[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (Cameras[0].activeInHierarchy)
            {
                foreach (GameObject i in Cameras)
                {
                    i.SetActive(false);
                }

                Cameras[1].SetActive(true);
            }

            else if (Cameras[1].activeInHierarchy)
            {
                foreach (GameObject i in Cameras)
                {
                    i.SetActive(false);
                }

                Cameras[0].SetActive(true);
            }
            
        }
    }
}
