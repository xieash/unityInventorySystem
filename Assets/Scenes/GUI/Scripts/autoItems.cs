using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.UIElements;

public class ScrollViewManager : MonoBehaviour
{
    public GameObject itemPrefab;
    public int itemCount;
    public Vector2 itemSize;

    private GridLayoutGroup gridLayoutGroup;

    public float itemSize_gen = 100f;
    public float itemSpacing = 10f;
    public bool isScriptEnabled = true; // 控制脚本运行的开关

    private void Start()
    {
       /* if (isScriptEnabled)
        {
            //獲取items的生成位置
            //RectTransform viewportRectTransform = GetComponent<ScrollRect>().viewport.GetComponent<RectTransform>();
            //RectTransform contentRectTransform = viewportRectTransform.Find("Content").GetComponent<RectTransform>();
            // 自动生成items
            for (int i = 0; i < itemCount; i++)
            {
                //GameObject item = Instantiate(itemPrefab, contentRectTransform);
                GameObject item = (GameObject)PrefabUtility.InstantiatePrefab(itemPrefab,GetComponent<ScrollRect>().content);
                item.name = "Item " + i;
                item.GetComponent<RectTransform>().sizeDelta = new Vector2(0, itemSize_gen);
            }
            // 调整Content的大小和位置
            RectTransform contentRectTransform = GetComponent<ScrollRect>().content.GetComponent<RectTransform>();
            contentRectTransform.sizeDelta = new Vector2(0, itemCount * (itemSize_gen + itemSpacing) - itemSpacing);
            contentRectTransform.anchoredPosition = Vector2.zero;

        }
        else return;*/
    }

    void OnValidate()
    {

        if (itemPrefab == null)
        {
            Debug.LogError("itemPrefab is null");
            return;
        }

        ScrollRect scrollRect = GetComponent<ScrollRect>();
        if (scrollRect == null)
        {
            Debug.LogError("ScrollRect component not found");
            return;
        }

        //GridLayoutGroup gridLayoutGroup = scrollRect.content.GetComponent<GridLayoutGroup>();
        if (gridLayoutGroup == null)
        {
           // Debug.LogError("GridLayoutGroup component not found");
            return;
        }


        if (gridLayoutGroup == null)
        {
            gridLayoutGroup = GetComponentInChildren<GridLayoutGroup>();
        }

        gridLayoutGroup.cellSize = itemSize;


        /*if (isScriptEnabled)
        {
            //獲取items的生成位置
            //RectTransform viewportRectTransform = GetComponent<ScrollRect>().viewport.GetComponent<RectTransform>();
            //RectTransform contentRectTransform = viewportRectTransform.Find("Content").GetComponent<RectTransform>();
            // 自动生成items
            /*for (int i = 0; i < itemCount; i++)
            {
                //GameObject item = Instantiate(itemPrefab, contentRectTransform);
                GameObject item = (GameObject)PrefabUtility.InstantiatePrefab(itemPrefab, GetComponent<ScrollRect>().content);
                item.name = "Item " + i;
                item.GetComponent<RectTransform>().sizeDelta = new Vector2(0, itemSize_gen);
            }
            // 调整Content的大小和位置
            RectTransform contentRectTransform = GetComponent<ScrollRect>().content.GetComponent<RectTransform>();
            contentRectTransform.sizeDelta = new Vector2(0, itemCount * (itemSize_gen + itemSpacing) - itemSpacing);
            contentRectTransform.anchoredPosition = Vector2.zero;*/
        /* for (int i = 0; i < itemCount; i++)
             {
                 GameObject item = Instantiate(itemPrefab, GetComponent<ScrollRect>().content);
                 item.name = "Item " + i;
                 RectTransform rectTransform = item.GetComponent<RectTransform>();
                 if (rectTransform != null)
                 {
                     rectTransform.sizeDelta = new Vector2(0, itemSize);
                 }
                 else
                 {
                     Debug.LogWarning("Item " + i + " does not have a RectTransform component.");
                 }
             }

         }
         else return; */


    }

}