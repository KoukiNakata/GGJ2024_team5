using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;
using TMPro;
using UnityEngine.UIElements;

/// <summary>
/// UIの挙動を管理するクラス
/// </summary>
public class UIdirector : MonoBehaviour
{
    [SerializeField] GameObject obj_gameOver;



    [SerializeField] TextMeshProUGUI tmp_gameOver;
    [SerializeField] Image panicImage;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void initialize()
    {
        obj_gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void activeGameOver()
    {
        gameObject.SetActive(true);
    }

    public void activeRetryButton()
    {

    }

}
