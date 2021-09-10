using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActorRazorPages.Models
{
    public class DataInMemory : IData
    {
        public List<Actor> ActorsList { get; set; }

        public List<Actor> ActorsInitializeData()
        {
            ActorsList = new List<Actor>() {
                new Actor() {
                    Id= 101,
                    FirstName= "FN1",
                    LastName= "LN1",
                    KnownFor="M1",
                    OscarWinner=true,
                    ImageName="a1.jpg"
                },
                new Actor(){
                    Id = 102,
                    FirstName= "FN2", 
                    LastName="LN2",
                    KnownFor= "M2",
                    OscarWinner=true, 
                    ImageName= "a2.jpg"
                }
        };
            return ActorsList;
        }


        public Actor GetActorById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return ActorsList.SingleOrDefault(a => a.Id == id);
            }
        }
    }
}
