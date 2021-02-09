using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapHeroPopup : MonoBehaviour
{
    public GameObject heroPrefab; // префаб героя
    public GameObject sourceHeroContainer; // герой игрока
    public GameObject targetHeroContainer; // контейнер для префабов героев, на которые можно произвести обмен
    public GameObject statsContainer; // контейнер для префабов с описанием изменения параметров
    public GameObject statsLinePrefab; // префаб с описанием изменения параметров
    public Image abilityIcon; // иконка новой способности
    public Text abilityName; // название новой способности
    public Text abilityDescription; // строка описания новой способности
    public Image currencyIcon; // иконка валюты
    public Text swapPrice; // цена за обмен

    public void OnCloseClick() // по клику на кнопку закрывается попап
    {

    }

    public void OnSwapClick() // по клику на кнопку происходит обмен героев
    {

    }
}
