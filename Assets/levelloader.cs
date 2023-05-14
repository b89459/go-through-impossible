using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelloader : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playpanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void level()
    {
        SceneManager.LoadScene(1);

    }
    public void level1()
    {
        SceneManager.LoadScene(2);
    }
    public void level2()
    {
        SceneManager.LoadScene(3);
    }
    public void level3()
    {
        SceneManager.LoadScene(4);
    }
    public void level4()
    {
        SceneManager.LoadScene(5);
    }
    public void play()
    {
        playpanel.SetActive(true);
    }
    public void exitbutton()
    {
        Application.Quit();
    }
}
