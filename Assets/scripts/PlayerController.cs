using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    private GameObject _selectedGameObject;

    private void Update()
    {
        SelectObject();
    }

    private void SelectObject()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hitInfo;

            if (Physics.Raycast(ray, out hitInfo))
            {
                var selected = InterfaceUtility.GetInterface<ISelectable>(hitInfo.collider.gameObject);

                _selectedGameObject = selected != null ? hitInfo.collider.gameObject : null;

                if (selected != null) selected.Selected();
            }
            else
            {
                _selectedGameObject = null;
            }
        }
    }
}
