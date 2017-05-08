using UnityEngine;
using System.Collections.Generic;

public class Backpack : MonoBehaviour {

    [SerializeField]
	public List<IPackable> Items;

    void useItem(int index)
    {
        Items[index].isUseable = true;
    }

    void stopUsingItem(int index)
    {
        Items[index].isUseable = false;
    }

    void moveItem(int oIndex, int nIndex)
    {
        IPackable temp = Items[nIndex];
        Items[nIndex] = Items[oIndex];
        Items[oIndex] = temp;
    }

    void tossItem(int index)
    {
        Items.Remove(Items[index]);
    }
}
