using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;

    private void Start()
    {
        _text1.DOText("trololo", 3); // замена
        _text2.DOText("pur-pur-pur", 3).SetRelative(); // дополнение
        _text3.DOText("TRATATATATA", 3, true, ScrambleMode.All); // настраиваемая замена. Здесь - перебором всех символов
        _text3.DOColor(Color.blue, 3);
    }
}
