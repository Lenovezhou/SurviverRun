using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ScrollbarTest : MonoBehaviour ,IBeginDragHandler,IEndDragHandler

{
	public void OnBeginDrag(PointerEventData data)
	{
		Debug.Log ("开始拖拽");
	}
	public void OnEndDrag(PointerEventData data)
	{
		Debug.Log ("结束拖拽");
	}


}
