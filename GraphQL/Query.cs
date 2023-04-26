using System.Linq;
using CommanderGQL.Data;
using CommanderGQL.Models;
using HotChocolate;
using HotChocolate.Data;

namespace CommanderGQL.GraphQL{

    public class Query
    {
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Platform> GetPlatform([ScopedService] AppDbContext context)//the query will come nmae of Platform
        //If u change the method name it will be the queryname 
        {
            return context.Platforms;
        }
        
        [UseDbContext(typeof(AppDbContext))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Command> GetCommand([ScopedService]AppDbContext context)
        {
            return context.Commands;
        }
    }
}