using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif


public class MenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame() 
    {
        SceneManager.LoadScene(1);// if start button is pressed load main game scene
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode(); // if in unityEditor exit play mode in else statement if not in editor quit application
#else
                 Application.Quit();  
#endif
    }
}
