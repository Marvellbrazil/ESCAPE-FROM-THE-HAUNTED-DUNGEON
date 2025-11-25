using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections.Generic;

public class StoryController : MonoBehaviour
{
    [Header("Settings")]
    public List<string> storyLines = new List<string>();
    public TextMeshProUGUI storyText;
    public string nextSceneName;
    public KeyCode nextKey = KeyCode.Space;

    private int currentLineIndex = 0;

    void Start()
    {
        if (storyLines.Count > 0)
        {
            storyText.text = storyLines[currentLineIndex];
        }
    }

    void Update()
    {
        // cek input untuk lanjut
    }

    void NextLine()
    {
        currentLineIndex++;

        if (currentLineIndex < storyLines.Count)
        {
            storyText.text = storyLines[currentLineIndex];
        }
        else
        {
            // ganti scene
        }
    }
}
