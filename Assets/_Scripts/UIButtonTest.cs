using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform), typeof(Button))]
public class UIButtonTest : MonoBehaviour 
{
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
    }

    // Use this for initialization
    void Start () 
    {
        AddListenerToButton();
	}

    public void TestButton()
    {
        Debug.Log("This is a test");
        DeleteListenerToButton();
        StartCoroutine(ReassignToButton());
    }

    private IEnumerator ReassignToButton()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("Reassigned to button");
        AddListenerToButton();
    }

    private void AddListenerToButton()
    {
        button.interactable = true;
        button.onClick.AddListener(TestButton);
    }

    private void DeleteListenerToButton()
    {
        button.interactable = false;
        button.onClick.RemoveListener(TestButton);
    }
}
