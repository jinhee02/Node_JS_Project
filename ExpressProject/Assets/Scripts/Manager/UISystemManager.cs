using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISystemManager : MonoBehaviour
{
    [SerializeField] private List<UIPanel> panels;
    [SerializeField] private UIPopup popupPrefabs;

    [SerializeField]
    private GameObject Canvas;
    private int currentPanellndex;
    private Stack<UIPopup> popupStack = new Stack<UIPopup>();

    public void ShowPanel(int index)
    {
        for(int i = 0; i < panels.Count; i++)
        {
            if (i == index)
            {
                panels[i].Show();
            }
            else
            {
                panels[i].Hide();
            }

        }
    }

    public void NextPanel()
    {
        currentPanellndex = (currentPanellndex + 1) % panels.Count;
        ShowPanel(currentPanellndex);
    }

    public void PreviousPanel()
    {
        currentPanellndex--;
        if(currentPanellndex < 0)
        {
            currentPanellndex = panels.Count - 1;
        }
        ShowPanel(currentPanellndex);
    }

    // Start is called before the first frame update
    void Start()
    {
        if(panels.Count > 0)
        {
            currentPanellndex = 0;
            ShowPanel(currentPanellndex);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            PreviousPanel();
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            NextPanel();
        }
    }
}
