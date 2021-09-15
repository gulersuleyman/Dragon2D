using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    public void YesButtonClick()
    {
        GameManager.Instance.RestartGame();
    }
    public void NoButtonClick()
    {

    }
}
