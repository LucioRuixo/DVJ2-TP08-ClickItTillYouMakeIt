﻿using UnityEngine;

public class UpgradeMenuContent : MonoBehaviour
{
    float ubHeight;

    public GameObject upgradeButtonPrefab;

    void OnEnable()
    {
        GameManager.onUpgradeInitialization += SetContentHeight;
    }

    void OnDisable()
    {
        GameManager.onUpgradeInitialization -= SetContentHeight;
    }

    void SetContentHeight(int upgradeAmount)
    {
        ubHeight = upgradeButtonPrefab.GetComponent<RectTransform>().rect.height;

        GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().sizeDelta.x, ubHeight * upgradeAmount);
    }
}