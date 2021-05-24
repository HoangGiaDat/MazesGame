using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.UI;
using UnityEngine.UI;
using LTAUnityBase.Base.DesignPattern;

public class ArrowController : LayoutGridSnake
{
    [SerializeField]
    Vector2 size = new Vector2(200, 200);
    [SerializeField]
    GameObject templeball;
    private Sprite mImageEven;
    void Start()
    {
        mImageEven = Resources.Load<Sprite>("stage/stage");
        LoadSeeBall(null);
    }
    void LoadSeeBall(object data)
    {
        Transform transParent = templeball.transform.parent;
        while (transParent.childCount > 1)
        {
            Transform transChild = transParent.GetChild(transParent.childCount - 1);
            transChild.SetParent(null, false);
            Destroy(transChild.gameObject);
        }
        
        for (int i = 0; i < 1000; i++)
        {
            SetBtnBet(i, transParent);
        }
        
    }
    

    void SetBtnBet( int i, Transform transParent)
    {
        GameObject img = Instantiate(templeball) as GameObject;
        if(1000 - i == 1)
        {
            img.transform.GetChild(0).gameObject.SetActive(false);
            img.transform.GetChild(1).gameObject.SetActive(true); 
        }
        img.transform.GetChild(0).GetComponent<Text>().text = (1000 - i).ToString();
        img.transform.GetComponent<Image>().sprite = mImageEven;
        AddGameObject(img.transform, size);
        img.SetActive(true);
        img.transform.SetParent(transParent, false);
    }
    private void OnDestroy()
    {
    }
}
