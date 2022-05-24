using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GantiSceneStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void PindahScreenGame(string namascene)
    {
        SceneManager.LoadScene(namascene);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
