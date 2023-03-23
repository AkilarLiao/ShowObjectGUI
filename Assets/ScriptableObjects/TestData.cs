using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PersonalData
{
    public int m_HP = 100;
    public int m_MP = 50;
    public Vector3 m_Position = Vector3.zero;
}
public class TestData : ScriptableObject
{
    public PersonalData m_PersonalData = new PersonalData();
}
