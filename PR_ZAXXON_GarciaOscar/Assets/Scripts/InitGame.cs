using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitGame : MonoBehaviour
{

    public float spaceshipSpeed;
    bool alive;
   

    // Start is called before the first frame update
    void Start()
    {

        spaceshipSpeed = 50f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Morir()
    {
        alive = false;
        spaceshipSpeed = 0f;
        PrefabGenerator instanciadorObst = GameObject.Find("PrefabGenerator").GetComponent<PrefabGenerator>();
        instanciadorObst.SendMessage("Parar");
        SceneManager.LoadScene(4);

    }
}
