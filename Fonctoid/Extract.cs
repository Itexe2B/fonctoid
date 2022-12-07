using System;

public class Extract : AbstractFonctoid
{
    public Extract()
	{     
    }

    public override void Action(List<int> IndexList)
    {
        List<List<String>> res = new List<List<String>>();
   
        foreach (Int32 Index in IndexList)
        {
            res.Add(Data.Data.csv[Index]);
        }

        Data.Data.csv = res;
    }




}
