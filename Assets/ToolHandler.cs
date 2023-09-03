using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ToolType { 
    None,
    Tool1,
    Tool2,
    Tool3
}
public class ToolHandler : MonoBehaviour
{

    public SceneManager sceneManager;
    public GameObject tool;

    public GameObject Tool1;
    public GameObject Tool2;
    public GameObject Tool3;

    public Transform ToolTransform;

    public ToolType toolType = ToolType.None;


    private GameObject _tool1;
    private GameObject _tool2;
    private GameObject _tool3;

    public GameObject Tool1Camera;

    void Start()
    {
        Tool1Camera.SetActive(false);
        InstanciateTools();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            sceneManager.ToolMode = true;
            _tool1.SetActive(true);
            _tool2.SetActive(false);
            _tool3.SetActive(false);
            Tool1Camera.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            sceneManager.ToolMode = true;
            _tool1.SetActive(false);
            _tool2.SetActive(true);
            _tool3.SetActive(false);
            Tool1Camera.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            sceneManager.ToolMode = true;
            _tool1.SetActive(false);
            _tool2.SetActive(false);
            _tool3.SetActive(true);
            Tool1Camera.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            sceneManager.ToolMode = false;
            _tool1.SetActive(false);
            _tool2.SetActive(false);
            _tool3.SetActive(false);
        }

    }


    public void InstanciateTools()
    {

        _tool1 = Instantiate(Tool1, ToolTransform.position, ToolTransform.rotation);
        _tool2 = Instantiate(Tool2, ToolTransform.position, ToolTransform.rotation);
        _tool3 = Instantiate(Tool3, ToolTransform.position, ToolTransform.rotation);


        _tool1.SetActive(false);
        _tool2.SetActive(false);
        _tool3.SetActive(false);

        Tool1Camera.SetActive(false);
    }


    public void SwitchTool()
    {
        _tool1.SetActive(false);
        _tool2.SetActive(false);
        _tool3.SetActive(false);


       
    }
}
