using System;
using System.Collections;
using System.Collections.Generic;
using MiniExcelLibs;
using UnityEngine;

public class MiniSample : MonoBehaviour
{
    public class UserAccount
    {
        public int Id { get; set; }
        public string Desc { get; set; }
        public string AssetName { get; set; }
        public bool Is3D { get; set; }
        public string UIGroupName { get; set; }
        public bool AllowMultiInstance { get; set; }
        public bool PauseCoveredUIForm { get; set; }
    }

    void Start()
    {
        var path = Application.streamingAssetsPath + "/UIFormConfig.xlsx";
        var rows = MiniExcel.Query<UserAccount>(path);
        foreach (var row in rows)
        {
            Debug.Log(
                $"Id: {row.Id}, Desc: {row.Desc}, AssetName: {row.AssetName}, Is3D: {row.Is3D}, UIGroupName: {row.UIGroupName}, AllowMultiInstance: {row.AllowMultiInstance}, PauseCoveredUIForm: {row.PauseCoveredUIForm}");
        }
    }
}