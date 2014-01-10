using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;


namespace Cheers_A02.Controllers
{
    public class Utilities
    {
        public bool CheckInTable(Guid guidPerson, Guid guidTable,ref int count)
        {

            //var CheckInDictionary = (Dictionary<Guid, Guid>)HttpContext.Current.Application["CheckInDictionary"];
            var checkedin = global.CheckInDictionary;
            if (checkedin == null)
                checkedin = new Dictionary<Guid, Guid>();

            if (checkedin.Count(person => person.Key == guidPerson) == 0)
                checkedin.Add(guidPerson, guidTable);
            else
            {
                count = checkedin.Count(x => x.Value == guidTable);
                return false;
            }

            count = checkedin.Count(x => x.Value == guidTable);
            global.CheckInDictionary = checkedin;
            return true;
        }
    }
    public static class global
    {
        public static Dictionary<Guid,Guid> CheckInDictionary{ get; set; }
    }
}
