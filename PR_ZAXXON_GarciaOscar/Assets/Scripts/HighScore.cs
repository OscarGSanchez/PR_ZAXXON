using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    [SerializeField] Text texto;



    // Start is called before the first frame update
    void Start()
    {
        texto.text = GameManager.highscore + " Pts.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
