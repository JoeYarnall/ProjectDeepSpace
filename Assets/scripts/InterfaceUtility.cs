using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class InterfaceUtility {

    public static void GetInterfaces<T>(out List<T> resultList, GameObject objectToSearch) where T : class
    {
        var list = objectToSearch.GetComponents<MonoBehaviour>();

        resultList = list.OfType<T>().Select(behaviour => behaviour as T).ToList();
    }

    public static T GetInterface<T>(GameObject objectToSearch) where T : class
    {
        var list = objectToSearch.GetComponents<MonoBehaviour>();

        return list.OfType<T>().Select(behaviour => behaviour as T).FirstOrDefault();
    }
}
