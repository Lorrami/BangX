using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NamesShowing : MonoBehaviour
{
    public List<GameObject> requiredToShow = new List<GameObject>();
    public GameObject mainButtonForShowing;
    public GameObject buttonToStart;

    private int _count = 1;
    public void SetButtonsActive()
    {
        buttonToStart.SetActive(true);
        foreach (var button in requiredToShow)
        {
            button.SetActive(true);
        }
    }
    public void ShowNames()
    {
        foreach (var button in requiredToShow)
        {
            button.GetComponentInChildren<Text>().text = GameParams.PlayersList[requiredToShow.IndexOf(button)].Name;
        }
        mainButtonForShowing.SetActive(false);
    }

    public void NameShowingForEachButton()
    {
        if (_count % 2 != 0)
        {
            gameObject.GetComponentInChildren<Text>().text = GameParams.PlayersList[requiredToShow.IndexOf(gameObject)].Role;
            _count++;
        }
        else
        {
            gameObject.GetComponentInChildren<Text>().text = GameParams.PlayersList[requiredToShow.IndexOf(gameObject)].Name;
            _count++;
        }
    }
}