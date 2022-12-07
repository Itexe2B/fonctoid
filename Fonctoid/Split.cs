using System;
using CsvHelper;

public class Split : AbstractFonctoid
{
    
    public Split()
    {
    }
    public override void Action(List<int> IndexList)
    {
        SplitColumn(IndexList);
    }
    
    public void SplitColumn(List<Int32> IndexList, string? Separator = ",")
    {
        List<List<String>> res = new List<List<String>>();
        List<List<String>> newList = new List<List<String>>(Data.Data.csv);
        List<List<String>> newList2 = new List<List<String>>();


        foreach (Int32 Index in IndexList)
        {
            newList2.Add(Data.Data.csv[Index]);
        }

        foreach (List<String> s in newList2)
            foreach (String s2 in s) {
                List<String> newList3 = new List<String>();
                newList3.Add(s2);
                res.Add(newList3);

               }

        Data.Data.csv = res;
    }
}
