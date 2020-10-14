using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SquareBehaviour : MonoBehaviour, IPointerEnterHandler
{
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(name + " PointerEnter");
    }

    #region Initialization

    void Awake()
    {

    }

    void Start()
    {
        //Debug.Log(name + " Pos: " + transform.position);
        //Debug.Log(name + "Local Pos: " + transform.localPosition);
    }

    #endregion

    #region Updating	 

    void Update()
    {
        //bool beingDragged;

        //if (Input.touchCount == 1)
        //{
        //    if (Input.GetTouch(0).phase == TouchPhase.Began)
        //        beingDragged = true;
        //    MousePositionTracker();
        //    if (Input.GetTouch(0).phase == TouchPhase.Ended)
        //    {
        //        beingDragged = false;
        //        AttemptToPlaceDefenderAt(Input.GetTouch(0).position);
        //    }
        //}
    }

    #endregion

    //private void MousePositionTracker()
    //{
    //    //Store start position to move from, based on objects current transform position.
    //    Vector2 start = transform.position;
    //    Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    mousePosition.z = transform.position.z;
    //    transform.position = Vector2.MoveTowards(start, mousePosition, speed * Time.deltaTime);
    //}


    //private void AttemptToPlaceDefenderAt(Vector2 gridPos)
    //{
    //    var starDisplay = FindObjectOfType<StarDisplay>();
    //    int defenderCost = defender.StarCost;
    //    if (starDisplay.HaveEnoughStars(defenderCost))
    //    {
    //        BlockSpawner(gridPos);
    //        starDisplay.SpendStars(defenderCost);
    //    }
    //}

    //private Vector2 GetSquareClicked()
    //{
    //    Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    //    Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
    //    Vector2 gridPos = SnapToGrid(worldPos);
    //    return gridPos;
    //}

    //private Vector2 SnapToGrid(Vector2 rawWorldPos)
    //{
    //    float newX = Mathf.RoundToInt(rawWorldPos.x);
    //    float newY = Mathf.RoundToInt(rawWorldPos.y);
    //    return new Vector2(newX, newY);
    //}

    //private void BlockSpawner(Vector2 gridPos)
    //{
    //    Defender newDefender = Instantiate(defender, gridPos, Quaternion.identity);
    //    newDefender.transform.parent = defenderParent.transform;
    //}


}