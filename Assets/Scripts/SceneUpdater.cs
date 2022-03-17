using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SceneUpdater : MonoBehaviour
{
    public List<InputField> names = new List<InputField>();

    public void FirstGameStart()
    {
        SceneManager.LoadScene("ChoosingScene");
    }
    public void Naming()
    {
        var isFull = true;
        foreach (var player in names)
        {
            if (player.text == "")
            {
                isFull = false;
            }
        }
        if (isFull)
        {
            var curScene = SceneManager.GetActiveScene().buildIndex;
            SendNamesToParams();
            SceneManager.LoadScene(curScene + 1);
        }
    }

    public void StartTheGame()
    {
        var curScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(curScene + 1);
    }
    public void Back()
    {
        var curScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(curScene - 1);
        GameParamsCleaner();
    }


    private void SendNamesToParams()
    {
        foreach (var player in names)
        {
            var role = "";
            RolesDistribution.RolesForFour(ref role);
            GameParams.PlayersList.Add(new GameParams.PlayerParams(player.text, role));
        }
    }

    private void GameParamsCleaner()
    {
        GameParams.PlayersList.Clear();
    }
}
