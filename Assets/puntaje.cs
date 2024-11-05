using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class gamemanager : MonoBehaviour
{
    public Text textpoints;
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        IncreasePoitns(0); 
    }
    public void IncreasePoitns(int pointsToAdd)
    {
        points = points + pointsToAdd;
        textpoints.text = "Puntos: " + points;

    }
}