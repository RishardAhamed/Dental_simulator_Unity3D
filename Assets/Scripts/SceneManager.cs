using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SceneManager : MonoBehaviour
{

    [SerializeField] private  Image img;
    [SerializeField] private GameObject freeCamera;
    [SerializeField] private GameObject operateCamera;

    [SerializeField] GameObject ManMouthClosed;
    [SerializeField] GameObject ManMouthOpened;

    [SerializeField] GameObject toggleOperateModeButton;

    [SerializeField] GameObject tool;

    private bool isOperateMode = false;
    private bool isToolMode = false;
    public bool ToolMode = false;

    public GameObject UseToolText;

    private void ToggleOperateMode()
    {

        if (!isOperateMode)
        {
            SwithToOperateMode();

        }
        else
        {
            SwithToFreeMode();
        }


        /*isOperateMode = !isOperateMode;

        if (!isOperateMode)
        {
            toggleOperateModeButton.SetActive(false);

        }
        operateCamera.SetActive(isOperateMode);
        faceOnly.SetActive(isOperateMode);

        toggleOperateModeButton.GetComponentInChildren<TMP_Text>().text = isOperateMode ? "Exit Operate Mode" : "Enter Operate Mode";

        freeCamera.SetActive(!isOperateMode);
        fullBody.SetActive(!isOperateMode);*/

    }



    public void ActivateTool()
    {

        ToolMode = true;
        tool.SetActive(true);
    }



    public void ShowUseToolText()
    {
        UseToolText.SetActive(true);

    }

    public void HideUseToolText()
    {
        UseToolText.SetActive(false);

    }


    private void SwithToOperateMode()
    {
        isOperateMode = true;
        operateCamera.SetActive(true);
        ManMouthOpened.SetActive(true);
        toggleOperateModeButton.GetComponentInChildren<TMP_Text>().text =  "Exit Operate Mode";

        freeCamera.SetActive(false);
        ManMouthClosed.SetActive(false);
        ShowUseToolText();
    }


    private void SwithToFreeMode()
    {
        isOperateMode = false;
        operateCamera.SetActive(false);
        ManMouthClosed.SetActive(false);
        toggleOperateModeButton.GetComponentInChildren<TMP_Text>().text = "Enter Operate Mode";
        
        freeCamera.SetActive(true);
        ManMouthOpened.SetActive(true);
        HideUseToolText();
    }

    private void SwitchToToolMode()
    {
        Debug.Log("Working");
        isOperateMode = !isOperateMode;
        isToolMode = !isToolMode;
        // isToolMode = true;
      
    }

    public void OnToggleOperateMode()
    {
       
        StartCoroutine(FadeInAndOut());
    }

    IEnumerator FadeInAndOut()
    {

        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            img.color = new Color(0, 0, 0, i);
            yield return null;
        }
        ToggleOperateMode();

        for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                img.color = new Color(0, 0, 0, i);
                yield return null;
            }
        
                
        
            
        
    }

}
