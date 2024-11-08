using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using TMPro;

public class Leaderboard : MonoBehaviour
{
    public GameObject leaderboardCanvas;
    public GameObject[] leaderboardEntries;

    public static Leaderboard instance;
    void Awake() { instance = this; }
    public void OnLoggedIn()
    {
        leaderboardCanvas.SetActive(false);
        DisplayLeaderboard();
    }
}
