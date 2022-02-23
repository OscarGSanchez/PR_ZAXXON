using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InitGame : MonoBehaviour
{
    AudioSource audiosource;
    public float spaceshipSpeed;
    bool alive;

    [SerializeField] Text scoreText;
    static float score;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.Play();
        spaceshipSpeed = 50f;

    }

    // Update is called once per frame
    void Update()
    {
        Texto();
    }

    public void Morir()
    {
        alive = false;
        spaceshipSpeed = 0f;
        PrefabGenerator instanciadorObst = GameObject.Find("PrefabGenerator").GetComponent<PrefabGenerator>();
        instanciadorObst.SendMessage("Parar");
        SceneManager.LoadScene(4);

    }

    public void Texto()
    {
        float tiempo = Time.timeSinceLevelLoad;

        if (spaceshipSpeed != 0)
        {
            score = Mathf.Round(tiempo) * spaceshipSpeed;
        }

        scoreText.text = Mathf.Round(score) + " mts.";    
    }
}
