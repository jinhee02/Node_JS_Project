using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController : MonoBehaviour
{
    bool _init = false;

    private void Awake()
    {
        Init();
    }

    public virtual bool Init()
    {
        if (_init) return false;
        _init = true;
        return true;
    }
}
