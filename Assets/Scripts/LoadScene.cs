using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public int scene;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            LoadLevel(0);
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            LoadLevel(1);
        }
        
    }
    public void LoadLevel(int Level)
    {
        SceneManager.LoadScene(Level, LoadSceneMode.Single);

    }
}
