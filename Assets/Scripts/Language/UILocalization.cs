using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Localization.Settings;

public class UILocalization : MonoBehaviour
{
  public Button chineseBtn;
  public Button englishBtn;

  void Start()
  {
    chineseBtn.onClick.AddListener(() => StartCoroutine(SetLocale(0)));
    englishBtn.onClick.AddListener(() => StartCoroutine(SetLocale(1)));

  }

  //Chinese:0 English:1
  IEnumerator SetLocale(int id)
  {
    {
      yield return LocalizationSettings.InitializationOperation;
      LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[id];
      Debug.Log(LocalizationSettings.SelectedLocale);
    }
  }


}
