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
    public bool isScriptEnabled = true; // ���ƽű����еĿ���

    private void Start()
    {
       /* if (isScriptEnabled)
        {
            //�@ȡitems������λ��
            //RectTransform viewportRectTransform = GetComponent<ScrollRect>().viewport.GetComponent<RectTransform>();
            //RectTransform contentRectTransform = viewportRectTransform.Find("Content").GetComponent<RectTransform>();
            // �Զ�����items
            for (int i = 0; i < itemCount; i++)
            {
                //GameObject item = Instantiate(itemPrefab, contentRectTransform);
                GameObject item = (GameObject)PrefabUtility.InstantiatePrefab(itemPrefab,GetComponent<ScrollRect>().content);
                item.name = "Item " + i;
                item.GetComponent<RectTransform>().sizeDelta = new Vector2(0, itemSize_gen);
            }
            // ����Content�Ĵ�С��λ��
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
            //�@ȡitems������λ��
            //RectTransform viewportRectTransform = GetComponent<ScrollRect>().viewport.GetComponent<RectTransform>();
            //RectTransform contentRectTransform = viewportRectTransform.Find("Content").GetComponent<RectTransform>();
            // �Զ�����items
            /*for (int i = 0; i < itemCount; i++)
            {
                //GameObject item = Instantiate(itemPrefab, contentRectTransform);
                GameObject item = (GameObject)PrefabUtility.InstantiatePrefab(itemPrefab, GetComponent<ScrollRect>().content);
                item.name = "Item " + i;
                item.GetComponent<RectTransform>().sizeDelta = new Vector2(0, itemSize_gen);
            }
            // ����Content�Ĵ�С��λ��
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