using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActorRazorPages.Models
{
    interface IData
    {
        List<Actor> ActorsList { get; set; }
        List<Actor> ActorsInitializeData();
        Actor GetActorById(int? id);
    }
}
