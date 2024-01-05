using System.Data.Common;
using System.Numerics;

public class Security : Person
{
     private string militaryRank;
    public string MilitaryRank
    {
        get
        {
            return militaryRank;
        }

        set
        {
            militaryRank = value;
        }
    }

}