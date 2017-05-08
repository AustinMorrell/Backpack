using UnityEngine;
using System.Collections;

public interface IPackable
{
    bool isUseable { get; set; }
    void Update();
}
