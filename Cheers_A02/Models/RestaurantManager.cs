using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cheers_A02.Models;
using System.ComponentModel;

namespace Cheers_A02.Models
{
    [DataObject]
    public class RestaurantManager
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public Restaurants1 GetRestaurant(Guid guidTable)
        {
            var database1 = new CheersEntities();
            var RestId = database1.Tables.FirstOrDefault(x => x.TableGUID == guidTable).LocatedIn;
            if (RestId != default(int))
            {
                return database1.Restaurants1.FirstOrDefault(y => y.RestId == RestId);
            }
            else
                return null;


        }  
        
    }
}