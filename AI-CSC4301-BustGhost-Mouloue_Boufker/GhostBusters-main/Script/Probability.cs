using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Probability : MonoBehaviour
{
    public Game click;
    public TextMeshPro probability;
    public double countproba = 0.027; 
    void Start()
    {
        click = FindObjectOfType(typeof(Game)) as Game;
        countproba= 0.027;
    }
    void Update()
    {   
        BayesianProbability(click.lastcheckedX, click.lastcheckedY, click.gx, click.gy);
        probability.text =  countproba.ToString();
    }
    void BayesianProbability(int lastcheckedx, int lastcheckedy, int ghostx, int ghosty) 
    {
        
        countproba= click.JointTProba("red", 0);
        

     }
}
       
    

