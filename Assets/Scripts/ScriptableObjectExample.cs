using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptableObjectExample : ScriptableObject
{
    [System.Serializable]
    public class Datas
    {
        public string name;
        public int weight;
        public int count;
    }

    public List<Datas> datas = new List<Datas>();

    public void ShowData()
    {
        Debug.Log("Show Data!");
    }
}
