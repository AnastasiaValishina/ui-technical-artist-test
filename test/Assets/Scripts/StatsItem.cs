using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsItem : MonoBehaviour
{
    public Text statName; // название параметра
    public Text sourceValue; // значение параметра исходного героя
    public Text targetValue; // значение параметра нового героя
    public Image arrow; // стрелка, которая меняет цвет в зависимости от увеличения/уменьшения параметра
    public Sprite greenArrow; // спрайт стрелки, если параметр нового героя БОЛЬШЕ параметра исходного героя
    public Sprite redArrow; // спрайт стрелки, если параметр нового героя МЕНЬШЕ параметра исходного героя
    public Color upValueColor; // цвет targetValue, если параметр нового героя БОЛЬШЕ параметра исходного героя
    public Color downValueColor; // цвет targetValue, если параметр нового героя МЕНЬШЕ параметра исходного героя
    public Color upValueOutlineColor; // цвет обводки targetValue, если параметр нового героя БОЛЬШЕ параметра исходного героя
    public Color downValueOutlineColor; // цвет обводки targetValue, если параметр нового героя МЕНЬШЕ параметра исходного героя

}
