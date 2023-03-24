using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Testing : MonoBehaviour
{
   
    private Grid<bool> grid;
    // Start is called before the first frame update
    void Start()
    {
        grid = new Grid<bool>(4, 2, 10f, new Vector3(0, 0), (Grid<bool> g, int x, int z) => new bool());

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            grid.SetGridObject(MousePosition3D.GetMouseWorldPosition(), true);
        }
        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetGridObject(MousePosition3D.GetMouseWorldPosition()));
        }
    }
}

