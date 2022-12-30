using System.Collections;
using System.Collections.Generic;
using TutorialGameLogic;
using TutorialGameModel;
using UnityEngine;

public class GameRunner : MonoBehaviour
{
    private TestModel _testModel;
    private GameLogic _gameLogic;

    private void Start()
    {
        _testModel = new TestModel();
        _gameLogic = new GameLogic();
    }

    private void Update()
    {
        _gameLogic.UpdateLogic(Time.deltaTime, _testModel);
    }
}
