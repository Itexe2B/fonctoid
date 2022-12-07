using System;
using CsvHelper;

public class Merge : AbstractFonctoid
{
    

    public Merge()
	{
     
	}

    public override void Action(List<Int32> IndexList)
    {
        Action(IndexList);
    }

    public void Action(List<Int32> IndexList, string? Separator = ",")
    {
        List<List<String>> res = new List<List<String>>();
        List<List<String>> newList = new List<List<String>>(Data.Data.csv);
        List<List<String>> newList2 = new List<List<String>>();
        List<String> newList3 = new List<String>();


        foreach (Int32 Index in IndexList)
        {
            
            newList2.Add(Data.Data.csv[Index]);
            newList.RemoveAt(Index);

        }

        foreach (List<String> s in newList2)
            foreach (String s2 in s)
                newList3.Add(s2);
        
        res.Add(newList3);

        foreach (List<String> s in newList)
            res.Add(s);

        Data.Data.csv = res;
    }


}
