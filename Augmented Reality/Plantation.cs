﻿// This code automatically generated by TableCodeGen
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Plantation : MonoBehaviour
{
    public GameObject bu1, bu2, bu3, bu4, bu5, tr1, tr2;
    int temp;
    int waterlevel;
    public TextAsset file;
    public void Start()
    {
        
        bu1.SetActive(false);
        bu2.SetActive(false);
        bu3.SetActive(false);
        bu4.SetActive(false);
        bu5.SetActive(false);
        tr1.SetActive(false);
        tr2.SetActive(false);

        Load(file);
        for(int i=1;i>=0;i++)
        {
            temp = int.Parse(Find_id(i.ToString()).temp);
            waterlevel = int.Parse(Find_id(i.ToString()).humid);
        }
    }
    private void Update()
    {
        if (temp >= 25 && temp <= 28 && waterlevel >= 75)
        {
            bu1.SetActive(true);
            bu2.SetActive(true);
            bu3.SetActive(true);
            bu4.SetActive(true);
            bu5.SetActive(true);
            tr1.SetActive(true);
            tr2.SetActive(true);
        }
        else if ((temp >= 0 && temp < 25 || temp >= 28 && temp <= 32) && (waterlevel >= 75))
        {
            tr1.SetActive(true);
            tr2.SetActive(true);
            bu1.SetActive(true);
            bu2.SetActive(true);
            bu3.SetActive(false);
            bu4.SetActive(false);
        }
        else if ((temp < 0 || temp > 32) && (waterlevel >= 75))
        {
            tr1.SetActive(false);
            tr2.SetActive(false);
            bu1.SetActive(true);
            bu2.SetActive(true);
            bu3.SetActive(true);
            bu4.SetActive(false);

        }
        else if ((temp >= 25 && temp <= 28) && (waterlevel >= 40))
        {
            tr1.SetActive(false);
            tr2.SetActive(false);
            bu1.SetActive(true);
            bu2.SetActive(true);
            bu3.SetActive(false);
            bu4.SetActive(true);

        }
        else if ((temp >= 0 && temp < 25 || temp >= 28 && temp <= 32) && (waterlevel >= 45))
        {
            bu1.SetActive(false);
            bu2.SetActive(false);
            bu3.SetActive(true);
            bu4.SetActive(true);
            bu5.SetActive(true);
            tr1.SetActive(false);
            tr2.SetActive(false);
        }
        else if ((temp < 0 || temp > 32) && (waterlevel >= 45))
        {
            bu1.SetActive(false);
            bu2.SetActive(false);
            bu3.SetActive(true);
            bu4.SetActive(false);
            bu5.SetActive(true);
            tr1.SetActive(false);
            tr2.SetActive(false);
        }
        else if (temp >= 25 && temp <= 28 && waterlevel <= 45 && waterlevel != 0)
        {
            bu1.SetActive(false);
            bu2.SetActive(false);
            bu3.SetActive(true);
            bu4.SetActive(true);
            bu5.SetActive(true);
            tr1.SetActive(false);
            tr2.SetActive(false);
        }
        else if ((temp > 0 && temp < 25 || temp >= 28 && temp <= 32) && (waterlevel <= 45 && waterlevel != 0))
        {
            bu1.SetActive(false);
            bu2.SetActive(false);
            bu3.SetActive(false);
            bu4.SetActive(true);
            bu5.SetActive(true);
            tr1.SetActive(false);
            tr2.SetActive(false);
        }
        else if ((temp < 0 || temp > 32) && (waterlevel <= 25 && waterlevel != 0))
        {
            bu1.SetActive(false);
            bu2.SetActive(false);
            bu3.SetActive(true);
            bu4.SetActive(false);
            bu5.SetActive(false);
            tr1.SetActive(false);
            tr2.SetActive(false);
        }
        else if (temp == 0 || waterlevel == 0)
        {

            bu1.SetActive(false);
            bu2.SetActive(false);
            bu3.SetActive(false);
            bu4.SetActive(false);
            bu5.SetActive(false);
            tr1.SetActive(false);
            tr2.SetActive(false);
        }
        else
        {

            bu1.SetActive(false);
            bu2.SetActive(false);
            bu3.SetActive(false);
            bu4.SetActive(false);
            bu5.SetActive(false);
            tr1.SetActive(false);
            tr2.SetActive(false);
        }

    }
    public class Row
    {
        public string id;
        public string temp;
        public string humid;
        public string uv;
        public string co;
        public string co2;
        public string h2;

    }

    List<Row> rowList = new List<Row>();
    bool isLoaded = false;

    public bool IsLoaded()
    {
        return isLoaded;
    }

    public List<Row> GetRowList()
    {
        return rowList;
    }

    public void Load(TextAsset csv)
    {
        rowList.Clear();
        string[][] grid = CsvParser2.Parse(csv.text);
        for (int i = 1; i < grid.Length; i++)
        {
            Row row = new Row();
            row.id = grid[i][0];
            row.temp = grid[i][1];
            row.humid = grid[i][2];
            row.uv = grid[i][3];
            row.co = grid[i][4];
            row.co2 = grid[i][5];
            row.h2 = grid[i][6];

            rowList.Add(row);
        }
        isLoaded = true;
    }

    public int NumRows()
    {
        return rowList.Count;
    }

    public Row GetAt(int i)
    {
        if (rowList.Count <= i)
            return null;
        return rowList[i];
    }

    public Row Find_id(string find)
    {
        return rowList.Find(x => x.id == find);
    }
    public List<Row> FindAll_id(string find)
    {
        return rowList.FindAll(x => x.id == find);
    }
    public Row Find_temp(string find)
    {
        return rowList.Find(x => x.temp == find);
    }
    public List<Row> FindAll_temp(string find)
    {
        return rowList.FindAll(x => x.temp == find);
    }
    public Row Find_humid(string find)
    {
        return rowList.Find(x => x.humid == find);
    }
    public List<Row> FindAll_humid(string find)
    {
        return rowList.FindAll(x => x.humid == find);
    }
    public Row Find_uv(string find)
    {
        return rowList.Find(x => x.uv == find);
    }
    public List<Row> FindAll_uv(string find)
    {
        return rowList.FindAll(x => x.uv == find);
    }
    public Row Find_co(string find)
    {
        return rowList.Find(x => x.co == find);
    }
    public List<Row> FindAll_co(string find)
    {
        return rowList.FindAll(x => x.co == find);
    }
    public Row Find_co2(string find)
    {
        return rowList.Find(x => x.co2 == find);
    }
    public List<Row> FindAll_co2(string find)
    {
        return rowList.FindAll(x => x.co2 == find);
    }
    public Row Find_h2(string find)
    {
        return rowList.Find(x => x.h2 == find);
    }
    public List<Row> FindAll_h2(string find)
    {
        return rowList.FindAll(x => x.h2 == find);
    }

}