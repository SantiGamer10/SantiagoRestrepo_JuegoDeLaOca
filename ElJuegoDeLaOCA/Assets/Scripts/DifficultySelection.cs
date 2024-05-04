using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DifficultySelection : MonoBehaviour
{
    [SerializeField] private List<BoardData> boardData = new();
    [SerializeField] private Button button;
    [SerializeField] private TMP_Dropdown dropDown;

    public Action<BoardData> sendData = delegate { };

    private void OnEnable()
    {
        button.onClick.AddListener(HandleButton);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(HandleButton);
    }

    private void Awake()
    {
        List<TMP_Dropdown.OptionData> temp = new();
        for (int i = 0; i < boardData.Count; i++)
        {
            temp.Add(new TMP_Dropdown.OptionData(boardData[i].nameData, null));
        }
        dropDown.AddOptions(temp);
    }

    private void HandleButton()
    {
        sendData?.Invoke(boardData[dropDown.value]);
        gameObject.SetActive(false);
    }
}
