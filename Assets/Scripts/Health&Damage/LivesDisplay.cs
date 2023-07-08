using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using System;


public class LivesDisplay : MonoBehaviour
{   

    private Health HealthInstance;
    
    public Image life3;
    public Image life2;
    public Image life1;
    /// Description:
    /// Standard Unity function called once per frame
    /// Inputs:
    /// none
    /// Returns:
    /// void (no return)
    /// 
    private void Update()
    {
        HealthInstance = FindObjectOfType<Health>();
        int currentLives = HealthInstance.currentLives;
    
         if (currentLives == 3)
         {
        life3.enabled = true;
        life2.enabled = true;
        life1.enabled = true;
        }
        if (currentLives == 2) {
        life3.enabled = false;
        life2.enabled = true;
        life1.enabled = true;
        } 
        if (currentLives == 1) {
        life3.enabled = false;
        life2.enabled = false;
        life1.enabled = true;
        } 
    }
   

}
