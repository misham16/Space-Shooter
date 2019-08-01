using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleChanger : MonoBehaviour
{
    public ParticleSystem ps1;
    public GameController gameController;
    

    // Start is called before the first frame update
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
        ps1 = GetComponent<ParticleSystem> ();      
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameController.score >= 100)
        {
            var main1 = ps1.main;
            main1.simulationSpeed = 20f;
            main1.startColor = Color.blue;
            main1.startSize = 1f;
        }
        
    }
}
