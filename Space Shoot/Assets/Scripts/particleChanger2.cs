using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleChanger2 : MonoBehaviour
{
    public ParticleSystem ps1;
    public GameController gameController;
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
            main1.simulationSpeed = 15f;
            main1.startColor = Color.green;
            main1.startSize = 0.5f;
        }
    }
}
