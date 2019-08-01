using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey (KeyCode.N))
            {
                SceneManager.LoadScene("final main");
            }
        if(Input.GetKey (KeyCode.E))
            {
                SceneManager.LoadScene("easy");
            }
        if(Input.GetKey (KeyCode.H))
            {
                SceneManager.LoadScene("hard");
            }
    }
}
