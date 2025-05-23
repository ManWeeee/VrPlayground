using ModestTree;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Management;

public class LevelInfoHolder : MonoBehaviour
{
    [SerializeField] private LevelInfo[] m_levelInfo;
    [SerializeField]
    private LevelInfo m_currentLevelInfo;

    public int LevelCount => m_levelInfo.Length;
    public Action<LevelInfo> LevelInfoChanged;
    public LevelInfo CurrentLevelInfo
    {
        get { return m_currentLevelInfo; }
        set { m_currentLevelInfo = value; }
    }

/*    private LevelInfo this[int index]
    {
        get { return m_levelInfo[index]; }
    }*/

    private void Start()
    {
        Container.Register(this);
        m_currentLevelInfo = m_levelInfo[0];
    }

    public LevelInfo GetLevelInfo(int index)
    {
        return m_levelInfo[index];
    }

    public int GetLevelInfoIndex(LevelInfo levelInfo)
    {
        return m_levelInfo.IndexOf(levelInfo);
    }

    public void LoadNewLevelInfo(LevelInfo info)
    {
        m_currentLevelInfo = info;
        LevelInfoChanged?.Invoke(m_currentLevelInfo);
    }
}
